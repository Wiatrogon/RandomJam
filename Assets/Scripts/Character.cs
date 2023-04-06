using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Dictionary<Dice.Type, int> inventory = new Dictionary<Dice.Type, int>();

    public int Level { get { return inventory.Sum(dice => dice.Value); } }
    public int MaxHP { get { return inventory.Sum(dice => (int) dice.Key * dice.Value); }}
    public string displayName;
    public int currentHP
    {
        get;
        private set;
    } = 0;

    public void AddDice(Dice.Type dice, int count = 1)
    {
        if (!inventory.ContainsKey(dice))
        {
            inventory.Add(dice, 0);
        }
        inventory[dice] += count;
        currentHP += (int) dice * count;
    }

    public int RollForDamage()
    {
        int damage = 0;
        foreach(var dice in inventory)
        {
            for(int i = 0; i< dice.Value; i++)
            {
                damage += Dice.Roll(dice.Key);
            }
        }
        return damage;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
}
