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
