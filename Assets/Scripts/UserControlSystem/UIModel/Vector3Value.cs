using System;
using UnityEngine;


[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(Vector3Value), order = 2)]
public class Vector3Value : ScriptableObject
{
    public ISelectabale CurrentValue { get; private set; }
    public Action<ISelectabale> OnSelected;

    public void SetValue(ISelectabale value)
    {
        CurrentValue = value;
        OnSelected?.Invoke(value);
    }
}
