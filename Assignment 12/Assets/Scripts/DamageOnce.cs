using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnce : AbilityComponent
{
    public override void use(GameObject player, GameObject enemy, int abilityType, int healOrDamage)
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }

        if (abilityType != 1 && healOrDamage !=0)
        {
            var enemyScript = enemy.GetComponent<EntityController>();
            enemyScript.Damage(amount);
        }
    }
}
