using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private UIFunctionality uIFunctionality;
    [SerializeField] private PickupSpawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PickupSpawner>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uIFunctionality.UpdateScore();
            spawner.ReturnPickupToPool(this.gameObject);
        }
    }
}
