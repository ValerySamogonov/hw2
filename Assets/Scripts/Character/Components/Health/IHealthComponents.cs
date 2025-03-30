public interface IHealthComponents
{
    float Health { get; }

    float MaxHealth { get; }

    void SetDamage(int damage);
}