using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    [SerializeField] private UIFunctionality uIFunctionality;
    [SerializeField] private PlayerSpawner playerSpawner;
    [SerializeField] private PickupSpawner pickupSpawner;

    // Start is called before the first frame update
    private void Start()
    {
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
        playerSpawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PlayerSpawner>();
        pickupSpawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PickupSpawner>();
    }

    public void StartGame()
    {
        uIFunctionality.SetText();
        playerSpawner.SpawnPlayer();
        pickupSpawner.SpawnAtRandomLocation();
    }

    public void EndGame()
    {
        uIFunctionality.ShowWinText();
        playerSpawner.GameWon();
        pickupSpawner.WonGame();
    }
}
