using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Facade facade;

    public int score { get; set; }

    [SerializeField] private int scoreToWin;
    private bool endGameCalled;

    // Start is called before the first frame update
    private void Start()
    {
        facade = GetComponent<Facade>();
        facade.StartGame();

        endGameCalled = false;
    }

    private void Update()
    {
        if(score >= scoreToWin && !endGameCalled)
        {
            endGameCalled = true;

            facade.EndGame();
        }
    }
}
