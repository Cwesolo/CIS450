using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public float moveSpeed;
    public float score;

    protected abstract void MovePlayer();

    protected abstract void IncrementScore();
    
}
