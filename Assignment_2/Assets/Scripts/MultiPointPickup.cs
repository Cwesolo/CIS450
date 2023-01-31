/*
 * Chandler Wesoloski
 * MultiPointPickup.cs
 * Assignment 2
 * Implementation of the givepoints abstract method for multipul points
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiPointPickup : Pickup
{
    private void Start()
    {
        ScoreAmt = 3;
    }

    public override int GivePoints()
    {
        return ScoreAmt;
    }
}
