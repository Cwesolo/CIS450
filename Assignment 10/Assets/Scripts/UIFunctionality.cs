using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIFunctionality : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField] private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponentInChildren<TextMeshProUGUI>();

        scoreText.text = "Score: " + score;
    }

    public void UpdateScore()
    {
        score++;

        scoreText.text = "Score: " + score;
    }
}
