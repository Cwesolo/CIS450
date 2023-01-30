using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public Pickup pickup;
    public Simulator simulator;

    private float startTime;
    private float changePickupScoreTime;
    private float despawnTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        changePickupScoreTime = startTime + 3;
        despawnTime = startTime + 10;
        pickup = gameObject.AddComponent<MultiPointPickup>();
        simulator = GameObject.FindGameObjectWithTag("Simulator").GetComponent<Simulator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time == changePickupScoreTime)
        {
            Debug.Log("Changed Score amount");
            Destroy(this.gameObject.GetComponent<Pickup>());
            pickup = gameObject.AddComponent<SinglePoint_Pickup>();
        }

        if(Time.time == despawnTime)
        {
            Debug.Log("destroying");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            simulator.UpdateScore(GivePoints());
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    public int GivePoints()
    {
        return pickup.GivePoints();
    }
}
