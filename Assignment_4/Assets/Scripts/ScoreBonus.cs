using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBonus : PlayerDecorator
{
    public PlayerBonus bonus;

    public ScoreBonus(PlayerBonus bonus)
    {
        this.bonus = bonus;
    }

    public override float speed
    {
        get
        {
            return bonus.speed + 0;
        }
        set
        {
            bonus.speed = value;
        }
    }

    public override int score
    {
        get
        {
            return bonus.score += 2;
        }
        set
        {
            bonus.score = value;
        }
    }
}
