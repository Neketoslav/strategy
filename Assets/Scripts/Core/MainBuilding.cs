using UnityEngine;

public class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
{
    [SerializeField]
    private GameObject _unitPrefabs;

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

    public void ProduceUnit()
    {
        Instantiate(_unitPrefabs, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity, _unitsParents);
    }


}
