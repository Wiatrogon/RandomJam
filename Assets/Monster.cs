using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    public void Combat()
    {
        Character player = Player.instance;
        player.TakeDamage(RollForDamage());
        TakeDamage(player.RollForDamage());
    }
}
