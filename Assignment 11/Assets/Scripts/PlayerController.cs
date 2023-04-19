using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isActive;
    private float moveVertical, moveHorizontal;
    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * moveVertical * moveSpeed * Time.deltaTime);
            transform.Translate(Vector3.right * moveHorizontal * moveSpeed * Time.deltaTime);

        }
    }

    public void SetActive(bool active)
    {
        isActive = active;
    }
}
