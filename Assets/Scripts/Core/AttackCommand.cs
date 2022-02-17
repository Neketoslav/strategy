using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : CommandExecutorBase<IAttackCommand>
{
    public override void ExecuteSpecificCommand<T>(T command)
    {
        Debug.Log("Attack");
    }
}
