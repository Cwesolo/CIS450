/*
 * Chandler Wesoloski
 * Simulator.cs
 * Assignment 2
 * Contains general logic for player and gameplay
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulator : MonoBehaviour
{
    //Public Variables
    public float timeLimitSeconds = 60;
    public Camera camera;
    public UIScript uIScript;
    public GameObject cube;
    public GameObject entity;

    //Private Variables
    [SerializeField] private int score;
    [SerializeField] private int scoreGoal;
    private RaycastHit hit;
    private string PickupTag = "Pickup";
    private bool isPlaying;

    // Start is called before the first frame update
    private void Start()
    {
        isPlaying = true;
        scoreGoal = 50;

        camera = GetComponentInChildren<Camera>();
        uIScript = GameObject.FindGameObjectWithTag("UI").GetComponent<UIScript>();
        StartCoroutine(SpawnEntities());
    }

    // Update is called once per frame
    private void Update()
    {
        MouseControl();
        GameState();

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    private void GameState()
    {
        // 0 indicates is still playing. 1 indicates the player has won, and 2 indicates the player has lost.
        if(score < scoreGoal)
        {
            uIScript.HasWon(0);
        }
        else if (score >= scoreGoal)
        {
            uIScript.HasWon(1);
            isPlaying = false;
            StopCoroutine(SpawnEntities());
        }
        else if (Time.time == timeLimitSeconds && score >= scoreGoal)
        {
            uIScript.HasWon(1);
            isPlaying = false;
            StopCoroutine(SpawnEntities());
        }
        else
        {
            uIScript.HasWon(2);
            isPlaying = false;
            StopCoroutine(SpawnEntities());

        }
    }

    /// <summary>
    /// Handles mouse input
    /// </summary>
    private void MouseControl()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag(PickupTag))
                {
                    Instantiate(cube, hit.point, Quaternion.identity);
                }
            }
        }
    }

    /// <summary>
    /// Updates the score when an int is passed in from another script
    /// </summary>
    /// <param name="_score"></param>
    public void UpdateScore(int _score)
    {
        score += _score;
    }

    /// <summary>
    /// Gets the Score for UI updates
    /// </summary>
    /// <returns></returns>
    public int GetScore()
    {
        return score;
    }

    /// <summary>
    /// Spawns pickups for the player to click on
    /// </summary>
    /// <returns></returns>
    IEnumerator SpawnEntities()
    {
        while (isPlaying)
        {
            int randx = Random.Range(-13, 13);
            int randy = Random.Range(-6, 8);

            Instantiate(entity, new Vector3(randx, randy, 4), Quaternion.identity);

            yield return new WaitForSeconds(.5f);

        }
    }
}
