/*
 * Chandler Wesoloski
 * Pickup.cs
 * Assignment 2
 * Contains the abstract method for giving points to the player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    protected int ScoreAmt;

    public abstract int GivePoints();
}
