using System;


[AttributeUsage(AttributeTargets.Field)]
public class InjectAssetAttribute : Attribute
{
    public readonly string _assetName;
    public InjectAssetAttribute(string assetName = null)
    {
        _assetName = assetName;
    }

}
