using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Goblin : Enemy
{
    private float DashLength = 2;

    private void Start()
    {
        health = 100;
        name = "Goblin";
        attackDmg = 10;
        movedist = 5;
    }

    public override void Move()
    {
        UnityEngine.Debug.Log("Moved the" + name + " "+ movedist +"space");
    }

    public void DashAttack()
    {
        UnityEngine.Debug.Log(name + " dashed " + DashLength + " Spaces and attacked");
    }
};
