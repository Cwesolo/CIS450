using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;

    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * moveHorizontal * moveSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
