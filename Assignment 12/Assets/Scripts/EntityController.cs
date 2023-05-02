using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    public int health;
    public HealthBar healthBar;

    private void Start()
    {
        health = 100;
        healthBar.SetMaxHealth(health);
    }

    public void Damage(int dmgAmount)
    {
        if(health> 0)
        {
            health -= dmgAmount;
            healthBar.SetHealth(health);
        }
    }

    public void Heal(int healAmount)
    {
        if(health < 100)
        {
            health += healAmount;
            healthBar.SetHealth(health);
        }
    }
}
