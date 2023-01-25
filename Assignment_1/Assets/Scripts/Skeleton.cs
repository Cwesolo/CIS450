using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        health = 75;
        name = "Skeleton";
        attackDmg = 6;
        movedist = 7;
    }
    public override void Move()
    {
        UnityEngine.Debug.Log("Moved the" + name + " " + movedist + "space");
    }

    public override void Attack()
    {
        UnityEngine.Debug.Log("Shot the player dealing " + attackDmg + " points of damage");

    }

}
