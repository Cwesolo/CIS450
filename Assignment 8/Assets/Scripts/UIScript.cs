using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;

    private void Start()
    {
        score = 0;
    }

    public void GetScore(int incomingScore)
    {
        score = score + incomingScore;

        scoreText.text = "Score: " + score; 
    }
}
