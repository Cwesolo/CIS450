using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIFunctionality : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private GameManager gameManager;
    private int score;
    private string textScore = "Score: ";

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        scoreText = GetComponentInChildren<TextMeshProUGUI>();    
    }

    public void UpdateScore()
    {
        score = score + 1;

        scoreText.text = textScore + score;

        gameManager.score = score;
    }

    public void SetText()
    {
        score = 0;

        scoreText.text = textScore + score;
    }

    public void ShowWinText()
    {
        scoreText.text = "You Win!";
    }

}
