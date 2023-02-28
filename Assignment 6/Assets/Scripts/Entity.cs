using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected int health;
    protected int damageAmount;
    protected float movementSpeed;
    protected string name;

    public abstract string GetDescription();
}
