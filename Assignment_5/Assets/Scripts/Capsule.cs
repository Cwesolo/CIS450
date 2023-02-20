using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Capsule : PlayerCharacter
{
    // Start is called before the first frame update
    void Awake()
    {
        this.name = "Capsule";
        this.health = 85;
        this.damage = 30;
        this.moveSpeed = 35;
        this.description = "The character chosen is " + name + " and has " + health + " health and does " + damage + " damage to enemies and has a movement speed of " + moveSpeed;
    }

    public override string GetDescription()
    {
        return description;
    }
}
