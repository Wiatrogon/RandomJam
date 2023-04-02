using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public static Player instance
    {
        get;
        private set;
    }

    public override void Start()
    {
        base.Start();
        if(instance == null)
        {
            instance = this;
        }
    }
}
