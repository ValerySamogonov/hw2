using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : IHealthComponents
{
    private float health = 100f;
    private float maxHealth = 100f;

    public float Health
    {
        get => health;
        private set
        {
            health = Mathf.Clamp(value, 0, MaxHealth);
            if (health <= 0)
            {
                SetDeath();
                // showUiGameOver();
            }
        }
    }

    public float MaxHealth => maxHealth;


    public void SetDamage(int damage)
    {
        Health -= damage;
    }


    private void SetDeath()
    {
        Debug.LogError("Character is dead");
    }
}