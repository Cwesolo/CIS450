using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CollectPickup();
        }
    }

    private void CollectPickup()
    {
        giveScore();

        DestroyPickup();
    }

    private void DestroyPickup()
    {
        Destroy(this);
    }

    public abstract void giveScore();
}
