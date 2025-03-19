using UnityEngine;

public interface IAttackComponent
{
    float Damage { get; }
    float AttackRange { get; }


    void Initialize(CharacterData characterData);
    void MakeDamage(Character attackTarget);
}
