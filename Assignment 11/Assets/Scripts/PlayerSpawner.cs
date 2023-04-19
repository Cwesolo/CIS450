using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Vector3 spawnLocation;
    [SerializeField] private PlayerController controller;

    public void SpawnPlayer()
    {
        GameObject _player = Instantiate(Player, spawnLocation, Quaternion.identity);

        controller = _player.GetComponent<PlayerController>();

        controller.SetActive(true);
    }

    public void GameWon()
    {
        controller.SetActive(false);
    }
}
