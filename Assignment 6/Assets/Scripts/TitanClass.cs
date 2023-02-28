using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanClass : Entity
{
    private void Awake()
    {
        health = 100;
        damageAmount = 1500;
        name = "Titan";
        movementSpeed = 50;
    }

    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health + " DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }
}
