using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class PlayerCharacter : MonoBehaviour
{
    protected float moveSpeed;
    protected int health;
    protected int damage;
    protected string name;
    protected string description;

    public abstract string GetDescription();
}
