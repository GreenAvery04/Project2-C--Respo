using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Strength : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        return true;
    }
}
