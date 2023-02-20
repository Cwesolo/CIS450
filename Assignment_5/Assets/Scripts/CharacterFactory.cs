using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private GameObject square;
    [SerializeField] private GameObject capsule;

    public GameObject ChooseCharacter(string charType)
    {
        if(charType == "circle")
        {
            return circle;
        }
        else if(charType == "square")
        {
            return square;
        }
        else if(charType == "capsule")
        {
            return capsule;
        }
        else
        {
            return null;
        }
    }
}
