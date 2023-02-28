using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreator : EntityCreator
{
    [SerializeField] GameObject[] PlayerClasses = new GameObject[3];

    public override GameObject CreateEntity(string name)
    {
        GameObject player = null;
        switch (name)
        {
            case "Warlock":
                player = PlayerClasses[0];
                break;
            case "Hunter":
                player = PlayerClasses[1];
                break;
            case "Titan":
                player = PlayerClasses[2];
                break;
        }

        return player;
    }
}
