using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Dictionary<int, int> inventory = new Dictionary<int, int>(); 
    public int currentHP = 6;

    public virtual void Start()
    {
        inventory.Add(6, 1);
        currentHP = MaxHP();
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
