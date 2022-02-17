using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCommand : CommandExecutorBase<IStopCommand>

{
    public override void ExecuteSpecificCommand<T>(T command)
    {
        Debug.Log("stop");
    }
}
