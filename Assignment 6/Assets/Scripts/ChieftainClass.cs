using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChieftainClass : Entity
{
    private void Awake()
    {
        health = 65;
        damageAmount = 1200;
        name = "Chieftain";
        movementSpeed = 55;
    }
    public override string GetDescription()
    {
        return "Class: " + name + " Health: " + health + " DamageAmount: " + damageAmount + " Movement Speed: " + movementSpeed;
    }

}
