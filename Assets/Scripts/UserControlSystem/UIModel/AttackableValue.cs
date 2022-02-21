using System;
using UnityEngine;


[CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(AttackableValue), order = 1)]
public class AttackableValue : ScriptableObject
{
    public ISelectabale CurrentValue { get; private set; }
    public Action<ISelectabale> OnNewValue;

    public void SetValue(ISelectabale value)
    {
        CurrentValue = value;
        OnNewValue?.Invoke(value);
    }
}
