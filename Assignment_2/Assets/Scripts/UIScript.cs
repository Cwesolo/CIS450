/*
 * Chandler Wesoloski
 * UIScript.cs
 * Assignment 2
 * Contains the logic for the UI system
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winLoseText;
    private Simulator simulator;

    // Start is called before the first frame update
    void Start()
    {
        simulator = GameObject.FindGameObjectWithTag("Simulator").GetComponent<Simulator>();
    }

    // Update is called once per frame
    void Update()
    {
        string _text = "Score: " + simulator.GetScore();

        scoreText.text = _text; 
    }

    public void HasWon(int hasWon)
    {
        if (hasWon == 1)
        {
            winLoseText.text = "You win!! :) Press R to play again!";
        }
        else if(hasWon == 0)
        {
            winLoseText.text = "";
        }
        else
        {
            winLoseText.text = "You lose! :( Press R to try again";
        }
    }
}
