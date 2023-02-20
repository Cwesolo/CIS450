using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using TMPro;
using UnityEditor;

public class UIFunctionality : MonoBehaviour
{
    [SerializeField] private GameObject Character;
    [SerializeField] private GameObject? temp = null;
    [SerializeField] private PlayerCharacter player;
    [SerializeField] private TextMeshProUGUI descriptionText;
    public CharacterFactory characterFactory;

    public void CreateCharacter(string characterType)
    {
        Character = characterFactory.ChooseCharacter(characterType);
        Vector3 _spawnPos = new Vector3(0, 0, 0);
        if(temp == null)
        {
            temp = Instantiate(Character, _spawnPos, Quaternion.identity);
            player = temp.GetComponent<PlayerCharacter>();
            descriptionText.text = player.GetDescription();
        }
    }

    public void DestroyCharacter()
    {
        Destroy(temp);
        descriptionText.text = "";
    }
}
