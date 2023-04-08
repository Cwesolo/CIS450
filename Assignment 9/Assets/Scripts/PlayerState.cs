using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlayerState
{
    void Move();
    void Attack();
    void idle();

    void SetActiveState();
}