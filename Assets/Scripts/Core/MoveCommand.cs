using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand<T>(T command)
    {
        Debug.Log("patroling!");
    }
}
