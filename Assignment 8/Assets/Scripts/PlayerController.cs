using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * 5 * Time.deltaTime);
        transform.Translate(Vector3.right * moveHorizontal * 5 * Time.deltaTime);
    }
}
