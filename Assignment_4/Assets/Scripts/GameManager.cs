using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Pickup;
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            int x = Random.Range(-14, 14);
            int z = Random.Range(-14, 14);

            Instantiate(Pickup, new Vector3(x, .5f, z), Quaternion.identity);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game_Level");
        }
    }
}
