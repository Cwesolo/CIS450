using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : PlayerDecorator
{
    public PlayerBonus bonus;

    public SpeedBonus(PlayerBonus bonus)
    {
        this.bonus = bonus;
    }

    public override float speed
    {
        get
        {
            return bonus.speed + 10;
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
            return bonus.score += 0;
        }
        set
        {
            bonus.score = value;
        }
    }
}
