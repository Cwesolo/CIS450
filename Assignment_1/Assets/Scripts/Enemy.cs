using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable, IAttack
{
    protected int health;
    protected int attackDmg;
    protected float movedist;
    protected string name;

    public abstract void Move();

    public virtual void Attack()
    {
        UnityEngine.Debug.Log("Attacked the player dealing " + attackDmg + " points of damage");
    }

    public void RegenHealth(int regenAmt)
    {
        UnityEngine.Debug.Log(name + "regenerated " + regenAmt + " points of health");
        health -= regenAmt;
    }

    public void TakeDamage(int damageAmt)
    {
        UnityEngine.Debug.Log(name + "Took " + damageAmt + " points of damage");
        health -= damageAmt;
    }
}
