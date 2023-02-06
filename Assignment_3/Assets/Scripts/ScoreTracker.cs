/*
 * Chandler Wesoloski
 * ScoreTracker.cs
 * Assignment 3
 * Updates score text and win text
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour, IObserver
{
    public PlayerController player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI WinText;

    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        player.RegisterObserver(this);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Score;

        if(Score == 10)
        {
            WinText.text = "You win! Press R to play again!";
        }
    }

    public void ObserverUpdate(int score)
    {
        this.Score = score;
    }

}
