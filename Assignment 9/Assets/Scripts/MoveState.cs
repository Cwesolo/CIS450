using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : MonoBehaviour , PlayerState
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private UIFunctionality uIFunctionality;

    private bool isActiveState;
    private float moveVertical;
    private float moveHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isActiveState)
        {
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
            {
                controller.SetState("Idle");
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                controller.SetState("Attacking");
            }
            else
            {
                Move();
            }
        }
    }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void idle()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * 5 * Time.deltaTime);
        transform.Translate(Vector3.right * moveHorizontal * 5 * Time.deltaTime);
    }

    public void SetActiveState()
    {
        isActiveState = true;
        uIFunctionality.UpdateStateText("Moving");
    }
}
