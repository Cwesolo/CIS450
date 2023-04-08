using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private UIFunctionality uIFunctionality;
    [SerializeField] private IdleState idleState;
    [SerializeField] private MoveState moveState;
    [SerializeField] private AttackingState attackingState;

    [SerializeField] private PlayerState currentstate;

    // Start is called before the first frame update
    void Start()
    {
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
        idleState = GetComponent<IdleState>();
        moveState = GetComponent<MoveState>();
        attackingState = GetComponent<AttackingState>();

        SetState("Idle");
    }

    public void SetState(string state)
    {

        if (state == "Idle")
        {
            uIFunctionality.UpdateStateText("Idle");
            currentstate = idleState;
            currentstate.SetActiveState();
            Debug.Log("Idle");
        }
        else if (state == "Moving")
        {
            uIFunctionality.UpdateStateText("Moving");
            currentstate = moveState;
            currentstate.SetActiveState();
            Debug.Log("Moving");
        }
        else
        {
            uIFunctionality.UpdateStateText("Attacking");
            currentstate = attackingState;
            currentstate.SetActiveState();
            Debug.Log("Attacking");
        }
    }
}
