using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolCommand : CommandExecutorBase<IPatrolCommand>
{
    public override void ExecuteSpecificCommand<T>(T command)
    {
        Debug.Log("patrol");
    }
}
