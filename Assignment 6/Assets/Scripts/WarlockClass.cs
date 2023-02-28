using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarlockClass : Entity
{
    private void Awake()
    {
        health = 75;
        damageAmount = 1000;
        name = "Warlock";
        movementSpeed = 75;
    }

    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health +" DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }
}
