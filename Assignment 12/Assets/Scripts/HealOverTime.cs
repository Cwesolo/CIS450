using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOverTime : AbilityComponent
{
    private float endTime;

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

        if (abilityType != 0 && healOrDamage != 1)
        {
            var playerScript = player.GetComponent<EntityController>();
            var enemyScript = enemy.GetComponent<EntityController>();
            endTime = Time.time + 5;
            StartCoroutine(DoOverTime(playerScript, enemyScript));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= endTime)
        {
            StopAllCoroutines();
        }
    }

    public override IEnumerator DoOverTime(EntityController player, EntityController enemy)
    {
        while (true)
        {
            player.Heal(amount);
            yield return new WaitForSeconds(.3f);
        }
    }
}
