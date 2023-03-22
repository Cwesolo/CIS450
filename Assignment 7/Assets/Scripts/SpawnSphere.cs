using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour, Command
{
    private EntityController entityController;
    private Stack<GameObject> Spheres = new();

    private void Start()
    {
        entityController = GetComponent<EntityController>();
    }

    public void Execute()
    {
        entityController.Spawn(false);
        Spheres.Push(entityController.GetSpawnedEntity());
    }

    public void Undo()
    {
        entityController.DestroyEntity(Spheres.Pop());
    }

}
