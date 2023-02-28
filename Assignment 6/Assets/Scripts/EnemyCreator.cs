using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : EntityCreator
{
    [SerializeField] private GameObject[] EnemyTypes = new GameObject[3];

    public override GameObject CreateEntity(string name)
    {
        GameObject _enemy = null;

        switch (name)
        {
            case "Knight":
                _enemy = EnemyTypes[0];
                break;
            case "Captain":
                _enemy = EnemyTypes[1];
                break;
            case "Chieftain":
                _enemy = EnemyTypes[2];
                break;
        }

        return _enemy;
    }
}
