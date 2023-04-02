using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Dictionary<int, int> inventory = new Dictionary<int, int>();
    public int currentHP
    {
        get;
        private set;
    } = 0;

public virtual void Start()
    {
        AddDice(6);
    }

    public void AddDice(int maxRoll, int count = 1)
    {
        if (!inventory.ContainsKey(maxRoll) ) 
        {
            inventory.Add(maxRoll, 0);
        }
        inventory[maxRoll] += count;
        currentHP += maxRoll*count;
    }

    public int MaxHP()
    {
        return inventory.Sum(dice => dice.Key * dice.Value);
    }

    public int RollForDamage()
    {
        int damage = 0;
        foreach(var dice in inventory)
        {
            for(int i = 0; i< dice.Value; i++)
            {
                damage += Random.Range(1, dice.Key + 1);
            }
        }
        return damage;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
}
