using UnityEngine;



public interface ISelectabale : IHealthHolder
{
    Transform PivotPoint { get; }

    Sprite Icon { get; }
    Outline Outline { get; set; }
    
}


