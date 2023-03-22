using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;

    private GameObject temp;

    public void Spawn(bool isCube)
    {
        int randx = Random.Range(-10, 10);
        int randz = Random.Range(-10, 10);

        if(isCube)
        {
            temp = Instantiate(cube, new Vector3(randx, .5f, randz), Quaternion.identity);
        }
        else
        {
            temp = Instantiate(sphere, new Vector3(randx, .5f, randz), Quaternion.identity); 
        }
    }

    public GameObject GetSpawnedEntity()
    {
        return temp;
    }

    public void DestroyEntity(GameObject entity)
    {
        Destroy(entity);
    }
}
