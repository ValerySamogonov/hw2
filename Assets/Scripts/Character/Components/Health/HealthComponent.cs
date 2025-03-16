using UnityEngine;

public class HealthComponent : IHealthComponents 
{
    private float health;
    private float maxHealth = 100;
   public float Health 
   {
    get
   {
        return health;
   }
   private set
   {
    health = Mathf.Clamp(value, 0, MaxHealth);
    if (health == 0)
    SetDeath();
   }
   }

   public float MaxHealth => maxHealth;


   public void SetDamage(int damage)
   {
        Health -= damage;
   }


   private void SetDeath()
   {
    Debug.LogError("HealthComponent.SetDeath called");
   }
}
