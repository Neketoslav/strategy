using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public static class AssetInjector
{
    private readonly static Type _injectAssetAttributeType = typeof(InjectAssetAttribute);
    public static T Inject<T>(this AssetContext context, T target)
    {
        var targetType = target.GetType();
        var allFields = targetType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        while (targetType != null)
        {

            for (int i = 0; i < allFields.Length; i++)
            {
                var fieldInfo = allFields[i];
                var injectAssetAttribute = fieldInfo.GetCustomAttributes(_injectAssetAttributeType) as InjectAssetAttribute;
                if (injectAssetAttribute == null)
                {
                    continue;
                }
                var objectToInject = context.GetObjectByType(fieldInfo.FieldType, injectAssetAttribute._assetName);
                fieldInfo.SetValue(target, objectToInject);
            }
            targetType = targetType.BaseType;
        }
        return target;
    }
}
