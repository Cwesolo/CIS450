using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIFunctionality : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    [SerializeField] ContainerComposite AbilitiesContainer;
    [SerializeField] EntityController playerController;

    private void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<EntityController>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        AbilitiesContainer = GameObject.FindGameObjectWithTag("Player").GetComponent<ContainerComposite>();
    }

    public void DamagePlayer()
    {
        playerController.Damage(5);
        text.text = "Did 5 Damage points to the player";
    }

    public void HealPlayerOnce()
    {
        AbilitiesContainer.use(Player, Enemy, 0, 0);
        text.text = "Healed the player by 3 health points";
    }

    public void HealPlayerOverTime()
    {
        AbilitiesContainer.use(Player, Enemy, 1, 0);
        text.text = "Healing the player by 2 health points for 5 seconds";
    }

    public void DamageEnemy()
    {
        AbilitiesContainer.use(Player, Enemy, 0, 1);
        text.text = "Damaging the Enemy by 5 damage points";
    }

    public void DamageEnemyOverTime()
    {
        AbilitiesContainer.use(Player, Enemy, 1, 1);
        text.text = "Damaging the Enemy by dealing 2 damage points for 5 seconds";
    }

    public void DoAll()
    {
        AbilitiesContainer.use(Player, Enemy, 2, 2);
        text.text = "Healing and damaging all at once";
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("Game");
    }
}
