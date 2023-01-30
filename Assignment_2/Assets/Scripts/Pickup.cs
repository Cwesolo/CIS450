using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    protected int ScoreAmt;

    public abstract int GivePoints();
}
