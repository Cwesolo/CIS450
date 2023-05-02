using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnce : AbilityComponent
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

        if (abilityType != 1 && healOrDamage !=1)
        {
            var playerScript = player.GetComponent<EntityController>();

            playerScript.Heal(amount);
        }
    }
}
