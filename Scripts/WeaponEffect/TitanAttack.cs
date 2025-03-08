using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class TitanAttack : Weapon.WeaponAttackEffect
{
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        user.health += 100; 
        user.attackDamage *= 5.2f; 
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        user.health -= 100; 
        user.attackDamage /= 5.2f; 
    }
}
