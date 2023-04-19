using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [SerializeField] private UIFunctionality uIFunctionality;
    [SerializeField] private GameObject Pickup;
    [SerializeField] private int PickupCount;

    [SerializeField] private Queue<GameObject> pickups;
    [SerializeField] private List<GameObject> activePickups;

    // Start is called before the first frame update
    void Start()
    {
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();

        pickups = new Queue<GameObject>();
        activePickups = new List<GameObject>();

        for(int i = 0; i < PickupCount; i++)
        {
            GameObject _temp = Instantiate(Pickup);
            _temp.SetActive(false);
            pickups.Enqueue(_temp);        
        }
    }
    public void SpawnAtRandomLocation()
    {
        for (int i = 0; i < PickupCount; i++)
        {
            int xcoord = Random.Range(-9, 9);
            int zcorrd = Random.Range(-9, 9);

            GameObject _temp = pickups.Dequeue();
            _temp.SetActive(true);
            _temp.transform.position = new Vector3(xcoord, .5f, zcorrd);
            _temp.transform.rotation = Quaternion.identity;

            activePickups.Add(_temp);
        }
    }

    public void ReturnPickupToPool(GameObject pickup)
    {
        pickup.SetActive(false);
        pickups.Enqueue(pickup);
        activePickups.Remove(pickup);

        uIFunctionality.UpdateScore();
    }

    public void WonGame()
    {
        //After winning all GameObjects are set inactive
        for(int i = 0; i < activePickups.Count; i++)
        {
            activePickups[i].SetActive(false);
        }
    }
}
