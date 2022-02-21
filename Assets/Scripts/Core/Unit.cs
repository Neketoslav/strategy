using UnityEngine;

public class Unit : MonoBehaviour, ISelectabale
{
	public float Health => _health;
	public float MaxHealth => _maxHealth;
	public Sprite Icon => _icon;

    public Outline Outline { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    [SerializeField] private float _maxHealth = 100;
	[SerializeField] private Sprite _icon;

	private float _health = 100;
}
