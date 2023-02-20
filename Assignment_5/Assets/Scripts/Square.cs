using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Square : PlayerCharacter
{
    // Start is called before the first frame update
    void Awake()
    {
        this.name = "Square";
        this.health = 100;
        this.damage = 15;
        this.moveSpeed = 25;
        this.description = "The character chosen is " + name + " and has " + health + " health and does " + damage + " damage to enemies and has a movement speed of " + moveSpeed;
    }

    public override string GetDescription()
    {
        return description;
    }
}
