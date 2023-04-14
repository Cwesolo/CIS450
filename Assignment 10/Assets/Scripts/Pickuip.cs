using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickuip : MonoBehaviour
{
    public UIFunctionality uIFunctionality;
    public ObjectPooler objectPooler;


    private void Start()
    {
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
        objectPooler = GameObject.FindGameObjectWithTag("ObjectPooler").GetComponent<ObjectPooler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uIFunctionality.UpdateScore();
            objectPooler.ReturnObjectToPool(this.tag,this.gameObject);
        }
    }


}
