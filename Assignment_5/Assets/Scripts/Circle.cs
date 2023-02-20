using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Circle : PlayerCharacter
{
    // Start is called before the first frame update
    void Awake()
    {
        this.name = "Circle";
        this.health = 75;
        this.damage = 25;
        this.moveSpeed = 45;
        this.description = "The character chosen is " + name + " and has " + health + " health and does " + damage + " damage to enemies and has a movement speed of " + moveSpeed;
    }

    public override string GetDescription()
    {
        return description;
    }
}
