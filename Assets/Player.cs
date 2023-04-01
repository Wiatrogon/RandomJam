using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private List<Dice>  inventory = new List<Dice>();
    public Dictionary<int, int> inventoryDict = new Dictionary<int, int>(); 
    public int currentHP = 6;
    private void Start()
    {
        inventory.Add(new Dice() );
        inventoryDict.Add(6, 1);

    }

    public int MaxHP()
    {
        return inventory.Sum(dice => dice.maxRoll);
    }

}
