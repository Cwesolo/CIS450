using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerBonus bonus;

    private Rigidbody rb;
    private float moveVertical;
    private float moveHorizontal;
    private int score;

    private void Awake()
    {
        bonus = new PlayerBonus(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * moveVertical * bonus.speed * Time.deltaTime);
        transform.Translate(Vector3.right * moveHorizontal * bonus.speed * Time.deltaTime);

       // Debug.Log(bonus.speed);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("SpeedBonus"))
        {
            bonus = new SpeedBonus(bonus);
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("ScoreBonus"))
        {
            bonus = new ScoreBonus(bonus);
            Destroy(col.gameObject);
        }
        else if(col.gameObject.CompareTag("Pickup"))
        {
            bonus.score++;
            Destroy(col.gameObject);
            score = bonus.score;
        }
    }

    public int Getscore()
    {
        return score;
    }
}
