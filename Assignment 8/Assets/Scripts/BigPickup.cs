using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPickup : Pickup
{
    private int pointsGiven = 3;
    public UIScript uIScript;

    private void Start()
    {
        uIScript = GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>();
    }



    public override void GiveScore()
    {
        
    }
}
