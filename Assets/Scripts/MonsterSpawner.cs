using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public Monster CreateMonster(MonsterSlot monsterSlot)
    {
        Monster monster = monsterSlot.gameObject.AddComponent<Monster>();
        monster.AddDice(6, Player.instance.Level);
        monster.displayName = "Goblin";
        return monster;
    }
}
