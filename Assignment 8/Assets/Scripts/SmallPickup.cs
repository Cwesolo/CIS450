using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPickup : Pickup
{
    private int pointsGiven = 1;

    public UIScript uIScript;

    private void Start()
    {
        uIScript = GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>();
    }

    public override void GiveScore()
    {
        uIScript.GetScore(pointsGiven);
    }
}
