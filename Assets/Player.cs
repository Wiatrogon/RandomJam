using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{

    private List<Dice>  inventory = new List<Dice>();
    public int currentHP = 6;
    private void Start()
    {
        inventory.Add(new Dice() );
    }

    public int MaxHP()
    {
        return inventory.Sum(dice => dice.maxRoll);
    }

}
