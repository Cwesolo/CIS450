using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour, Command
{
    private EntityController entityController;
    private Stack<GameObject> Cubes = new();

    private void Start()
    {
        entityController = GetComponent<EntityController>();
    }

    public void Execute()
    {
        entityController.Spawn(true);
        Cubes.Push(entityController.GetSpawnedEntity());
    }

    public void Undo()
    {
        entityController.DestroyEntity(Cubes.Pop());
    }
}
