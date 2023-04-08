using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingState : MonoBehaviour , PlayerState
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private UIFunctionality uIFunctionality;

    [SerializeField] private int dmgAmount;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();
        uIFunctionality = GameObject.FindGameObjectWithTag("UI").GetComponent<UIFunctionality>();
    }

    public void Attack()
    {
        uIFunctionality.UpdateStateText("Attacking");
        StartCoroutine(PerformAttack());
    }

    public void idle()
    {
        Debug.Log("This not the idle state.");
    }

    public void Move()
    {
        Debug.Log("Player cant move while attacking");
    }

    public void SetActiveState()
    {
        Attack();
    }

    IEnumerator PerformAttack()
    {
        yield return new WaitForSeconds(3.0f);

        controller.SetState("Idle");
    }
}
