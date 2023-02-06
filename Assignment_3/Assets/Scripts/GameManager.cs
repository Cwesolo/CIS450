/*
 * Chandler Wesoloski
 * GameManager.cs
 * Assignment 3
 * Handles Spawning the pickups and restarting the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IObserver
{
    public GameObject pickUp;
    public PlayerController player;
   [SerializeField] private int score;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        player.RegisterObserver(this);

        SpawnPickUps();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game_Scene");
        }

        if(score == 10)
        {
            StartCoroutine(ResetLevel());
        }
    }

    public void ObserverUpdate(int score)
    {
        this.score = score;
    }

    private void SpawnPickUps()
    {
        for (int i = 0; i < 9; i++)
        {
            int randx = Random.Range(-9, 9);
            int randz = Random.Range(-9, 9);

            Instantiate(pickUp, new Vector3(randx, .5f, randz), Quaternion.identity);
        }
    }

    IEnumerator ResetLevel()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Game_Scene");
    }
}
