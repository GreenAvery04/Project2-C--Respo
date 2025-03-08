using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using static CreatorKitCode.Weapon;

public class Sharpness : Weapon.WeaponAttackEffect
{
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.damage *= 5.0f; // Damage goes by 60
        attackData.critChance += 10.0f; // Increases Critical Hit by 10%
    }

    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {



    }
}
