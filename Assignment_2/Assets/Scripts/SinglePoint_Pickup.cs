/*
 * Chandler Wesoloski
 * SinglePoint_Pickup.cs
 * Assignment 2
 * Implementation of the givepoints abstract method
 */

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SinglePoint_Pickup : Pickup
{
    private void Start()
    {
        ScoreAmt = 1;
    }

    public override int GivePoints()
    {
        return ScoreAmt;
    }
}
