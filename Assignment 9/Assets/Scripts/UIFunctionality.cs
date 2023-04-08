using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIFunctionality : MonoBehaviour
{
    [SerializeField] public  TextMeshProUGUI stateText;

    private string partOfStateText = "State: ";

    private void Awake()
    {
        stateText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateStateText(string state)
    {
        if(state == "Idle")
        {
            stateText.text = partOfStateText + "Idle";
        }
        else if(state == "Moving")
        {
            stateText.text = partOfStateText + "Moving";
        }
        else if (state == "Attacking")
        {
            stateText.text = partOfStateText + "Moving \n Player can do this98y much " + 10;
        }

    }
}
