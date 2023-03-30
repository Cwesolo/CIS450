using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPickup : Pickup
{
    private int pointsGiven;
    public UIScript uIScript;

    private void Start()
    {
        uIScript = GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>();

        pointsGiven = 3;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            RandomScore();
        }

        base.OnTriggerEnter(other);
    }

    public override void GiveScore()
    {
        uIScript.GetScore(pointsGiven);
    }

    public override void RandomScore()
    {
        pointsGiven = Random.Range(2, 5);
    }
}
