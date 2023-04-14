using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class ObjectPooler : MonoBehaviour
{
    public List<Pool> pools;
    public static ObjectPooler instance;
    public Dictionary<string, Queue<GameObject>> poolDictionary;
    public int xmin, xmax, zmin, zmax;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        poolDictionary  = new Dictionary<string, Queue<GameObject>>();

        FillPoolWithInactiveObjects();

        SpawnObjectsFromPool("Pickup", pools[0].size);
    }

    private void FillPoolWithInactiveObjects()
    {
        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();
            for(int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public void SpawnObjectsFromPool(string tag, int numOfObjectsToSpawn)
    {
        if(!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag  + " does not exist");
            return;
        }

        for(int i = 0; i < numOfObjectsToSpawn; i++)
        {
            GameObject objectToSpawn = poolDictionary[tag].Dequeue();

            objectToSpawn.SetActive(true);
            objectToSpawn.transform.position = GetRandomCoords();
            objectToSpawn.transform.rotation = Quaternion.identity;
        }
    }

    public void ReturnObjectToPool(string tag, GameObject objectToReturn)
    {
        objectToReturn.SetActive(false);

        poolDictionary[tag].Enqueue(objectToReturn);

    }

    private Vector3 GetRandomCoords()
    {
        return new Vector3(Random.Range(xmin, xmax), 0.5f, Random.Range(zmin, zmax));
    }
}
