using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerClassDescription;
    [SerializeField] private TextMeshProUGUI enemyClassDescription;
    [SerializeField] private PlayerCreator playerSpawner;
    [SerializeField] private EnemyCreator enemySpawner;


    private GameObject player;
    private Entity playerEntity;
    private GameObject enemy;
    private Entity enemyEntity;
    private GameObject playerTemp = null;
    private GameObject enemyTemp = null;


    public void SpawnPlayer(string type)
    {
        player = playerSpawner.CreateEntity(type);
        Vector3 _spawnPos = new Vector3(-2.5f, .5f, -2);

        if(playerTemp == null)
        {
            playerTemp = Instantiate(player, _spawnPos, Quaternion.identity);
            playerEntity = playerTemp.GetComponent<Entity>();

            playerClassDescription.text = playerEntity.GetDescription();
        }
    }

    public void SpawnEnemy(string type)
    {
        enemy = enemySpawner.CreateEntity(type);
        Vector3 _spawnPos = new Vector3(2.5f, .5f, -2);

        if(enemyTemp == null)
        {
            enemyTemp = Instantiate(enemy, _spawnPos, Quaternion.identity);
            enemyEntity = enemyTemp.GetComponent<Entity>();

            enemyClassDescription.text = enemyEntity.GetDescription();
        }
    }

    public void DestroyEntities()
    {
        Destroy(playerTemp);
        Destroy(enemyTemp);

        playerClassDescription.text = "";
        enemyClassDescription.text = "";
    }
}
