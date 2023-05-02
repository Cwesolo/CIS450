using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerComposite : AbilityComponent
{
    public List<AbilityComponent> abilites = new List<AbilityComponent>();

    public override void use(GameObject player, GameObject enemy, int abilityType, int healOrDamage)
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if(enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
        }

        for(int i = 0; i < abilites.Count; i++)
        {
            abilites[i].use(player, enemy, abilityType, healOrDamage);
        }
    }

    public override AbilityComponent GetChildItem(int item)
    {
        return abilites[item];
    }

    public override void Add(AbilityComponent ability)
    {
        abilites.Add(ability);
    }

    public override void Remove(AbilityComponent ability)
    {
        abilites.Remove(ability);
    }
}
