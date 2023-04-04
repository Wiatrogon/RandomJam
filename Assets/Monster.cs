using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    public void Combat()
    {
        if(currentHP <= 0)
        {
            return;
        }
        Character player = Player.instance;
        player.TakeDamage(RollForDamage());
        TakeDamage(player.RollForDamage());
        if(currentHP <= 0)
        {
            DropLoot();
        }
    }

    public void DropLoot()
    {
        foreach(var item in inventory)
        {
            Player.instance.AddDice(item.Key, item.Value);
        }
    }
}
