using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other)
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
        Destroy(this);
    }

    public abstract void GiveScore();
}
