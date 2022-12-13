using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int addHP;
        
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(addHP);
        return true;
    }
}
