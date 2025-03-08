using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class BulkyEffect : EquipmentItem.EquippedEffect
{
    public override void Equipped(CharacterData user)
    {
        user.health += 50; // Health Goes by 50
        user.attackDamage *= 1.2f; // Attack goes by 20


    }

    public override void Removed(CharacterData user)
    {

        user.health -= 50; // Remove health bonus
        user.attackDamage /= 1.2f; // Reset attack damage

    }
}
