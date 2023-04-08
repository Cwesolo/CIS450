using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : MonoBehaviour , PlayerState
{

    [SerializeField] private PlayerController controller;
    [SerializeField] private UIFunctionality uIFunctionality;

    private bool isActiveState;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveState)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                controller.SetState("Attacking");
            }
            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) 
            {
                controller.SetState("Moving");
            }
        }
    }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }

    public void idle()
    {
        uIFunctionality.UpdateStateText("Idle");
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void SetActiveState()
    {
        isActiveState = true;
        idle();
    }
}
