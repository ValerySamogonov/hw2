using UnityEngine;

public class ImmortalHealthComponent : IHealthComponents
{
    public float Health => 100;
    public float MaxHealth => 100;
public void SetDamage(int damage)
{
            Debug.Log("Youre stupid, I'm immortalObject!___loh");

}
}
