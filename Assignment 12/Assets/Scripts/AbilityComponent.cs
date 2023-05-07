using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityComponent : MonoBehaviour
{
    [Tooltip("This is the amount of damage or healing that will be done")]
    public int amount;

    public abstract void use(GameObject player, GameObject Enemy, int abilityType, int healOrDamage);

    public virtual void Add(AbilityComponent ability)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }

    public virtual void Remove(AbilityComponent ability)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }

    public virtual AbilityComponent GetChildItem(int item)
    {
        throw new System.NotSupportedException("GetChildItem() is not supported for " + this.GetType().Name);
    }

    public virtual IEnumerator DoOverTime( EntityController player, EntityController enemy)
    {
        throw new System.NotSupportedException("DoOverTime() is not supported for " + GetType().Name);
    }
}
