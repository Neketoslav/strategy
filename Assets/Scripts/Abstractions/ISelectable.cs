using UnityEngine;



public interface ISelectabale
{
    float Health { get; }
    float MaxHealth { get; }
    Sprite Icon { get; }
    Outline Outline { get; set; }
    
}


