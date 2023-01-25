using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy
{
    private float JumpHeight = 10.0f;

    private void Start()
    {
        health = 25;
        name = "Slime";
        attackDmg = 3;
        movedist = 1;
    }

    public override void Move()
    {
        Debug.Log(name + "Jumped and moved " + movedist + " space");
    }

    public void Jump()
    {
        Debug.Log(name = " jumped " + JumpHeight + " spaces up");
    }
}
