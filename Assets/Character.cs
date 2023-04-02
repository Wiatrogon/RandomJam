using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Dictionary<int, int> inventory = new Dictionary<int, int>(); 
    public int currentHP = 6;
    private void Start()
    {
        inventory.Add(6, 1);
        currentHP = MaxHP();
    }

    public int MaxHP()
    {
        return inventory.Sum(dice => dice.Key * dice.Value);
    }

}
