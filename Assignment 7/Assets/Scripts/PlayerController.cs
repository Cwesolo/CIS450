using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SpawnSphere spawnSphere;
    [SerializeField] private SpawnCube spawnCube;

    [SerializeField] Stack<Command> commandHistory;

    private void Awake()
    {
        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        //Spawns Cube
        if (Input.GetKeyDown(KeyCode.E))
        {
            spawnCube.Execute();
            commandHistory.Push(spawnCube);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            spawnSphere.Execute();
            commandHistory.Push(spawnSphere);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(commandHistory.Count > 0)
            {
                Command _lastCommand = commandHistory.Pop();

                _lastCommand.Undo();
            }
        }
    }
}
