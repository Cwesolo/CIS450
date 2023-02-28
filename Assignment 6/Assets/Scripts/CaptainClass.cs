using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainClass : Entity
{
    private void Awake()
    {
        health = 42;
        damageAmount = 1400;
        name = "Captain";
        movementSpeed = 75;
    }
    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health + " DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }
}
