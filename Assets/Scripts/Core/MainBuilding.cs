using UnityEngine;

public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectabale
{

    [SerializeField]
    private Transform _unitsParents;

    [SerializeField]
    private float _maxHealth = 1000;

    [SerializeField]
    private Sprite _icon;

    private float _health = 1000;

    private Outline _outline;

    public float Health => _health;

    public float MaxHealth => _maxHealth;

    public Sprite Icon => _icon;

    public Outline Outline { get => _outline; set => _outline = value; }

    public void Awake()
    {
        _outline = GetComponent<Outline>();
        _outline.OutlineWidth = 0;
    }

    public override void ExecuteSpecificCommand<T>(T command)
    {
        Debug.Log("a");
    }

    //public override void ExecuteSpecificCommand<T>(IProduceUnitCommand command)
    //{
    //    Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity, _unitsParents);
    //}
}
