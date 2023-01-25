using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    public Enemy slime1;
    public Enemy goblin1;

    public List<Enemy> enemies = new List<Enemy>();
    public List<IDamageable> damageables = new List<IDamageable>();

    // Start is called before the first frame update
    void Start()
    {
        //Creating the slime and goblin
        Debug.Log("Creating a goblin and a slime");
        slime1 = new Slime();
        goblin1 = new Goblin();

        slime1.Move();
        goblin1.Move();

        //Adds enemies to the list
        for(int i = 0; i < 2; i++)
        {
            enemies.Add(new Slime());
            enemies.Add(new Goblin());
            enemies.Add(new Skeleton());
        }

        //Adds Damageable entities to the list
        for (int i = 0; i < 2; i++)
        {
            damageables.Add(new Slime());
            damageables.Add(new Goblin());
            damageables.Add(new Skeleton());
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Calls abstract method
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy == null)
                    break;

                enemy.Move();
            }
        }

        //Calls interface method
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IDamageable damageable in damageables)
            {
                if (damageable == null)
                    break;

                damageable.TakeDamage(10);
            }
        }
        
    }
}