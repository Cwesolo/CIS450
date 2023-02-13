using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Entity
{
    Rigidbody rb;

    private float moveVertical;
    private float moveHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void IncrementScore()
    {
        throw new System.NotImplementedException();
    }

    protected override void MovePlayer()
    {
        
    }
}
