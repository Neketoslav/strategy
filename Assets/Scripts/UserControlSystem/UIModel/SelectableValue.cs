using System;
using UnityEngine;


[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
public class SelectableValue : ScriptableObject
{
    public ISelectabale CurrentValue { get; private set; }
    public Action<ISelectabale> OnSelected;

    public void SetValue(ISelectabale value)
    {
        CurrentValue = value;
        OnSelected?.Invoke(value);
    }
}
