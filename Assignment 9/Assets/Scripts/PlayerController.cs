using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerState idleState;
    [SerializeField] private PlayerState moveState;
    [SerializeField] private PlayerState attackingState;

    [SerializeField] private PlayerState currentstate;

    // Start is called before the first frame update
    void Start()
    {
        idleState = GetComponent<IdleState>();
        moveState = GetComponent<MoveState>();
        attackingState = GetComponent<AttackingState>();

        currentstate = idleState;
        currentstate.SetActiveState();
    }

    public void SetState(string state)
    {

        if (state == "Idle")
        {
            currentstate = idleState;
            currentstate.SetActiveState();
            Debug.Log("Idle");
        }
        else if (state == "Moving")
        {
            currentstate = moveState;
            currentstate.SetActiveState();
            Debug.Log("Moving");
        }
        else
        {
            currentstate = attackingState;
            currentstate.SetActiveState();
            Debug.Log("Attacking");
        }

    }
}
