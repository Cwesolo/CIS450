using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterClass : Entity
{
    private void Awake()
    {
        health = 50;
        damageAmount = 1700;
        name = "Hunter";
        movementSpeed = 100;
    }
    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health + " DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }
}