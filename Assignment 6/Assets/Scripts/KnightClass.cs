using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightClass : Entity
{
    private void Awake()
    {
        health = 85;
        damageAmount = 1000;
        name = "Knight";
        movementSpeed = 80;
    }
    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health + " DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }
}
