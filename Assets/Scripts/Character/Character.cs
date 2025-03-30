using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private CharacterData characterData;

    public IHealthComponents HealthComponent { get; protected set; }
    public IMovementComponent MovementComponent { get; protected set; }
    public IAttackComponent AttackComponent { get; protected set; }

    public virtual void Initialize()
    {
        MovementComponent = new DefaultMovementComponent();
        MovementComponent.Initialize(characterData);
        AttackComponent = new AttackComponent();
        AttackComponent.Initialize(characterData);
        HealthComponent = new HealthComponent();
    }

    private void Start()
    {
        Initialize();
    }

    protected abstract void Update();
}