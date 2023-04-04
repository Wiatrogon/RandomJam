using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : Character
{
    public static Player instance
    {
        get;
        private set;
    }
    public void Start()
    {
        displayName = "Hero";
        AddDice(6);
        if(instance == null)
        {
            instance = this;
        }
    }
}
