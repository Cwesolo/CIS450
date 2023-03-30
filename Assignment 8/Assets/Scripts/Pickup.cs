using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectPickup();
        }
    }

    protected void CollectPickup()
    {
        GiveScore();

        DestroyPickup();
    }

    private void DestroyPickup()
    {
        Destroy(this.gameObject);
    }

    public abstract void GiveScore();

    public virtual void RandomScore()
    {
    }
}
