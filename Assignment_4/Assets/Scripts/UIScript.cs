using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public PlayerController playerController;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI RestartText;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + playerController.Getscore();

        if (playerController.Getscore() >= 10)
        {
            RestartText.text = "Press R to restart";
        }
    }
}
