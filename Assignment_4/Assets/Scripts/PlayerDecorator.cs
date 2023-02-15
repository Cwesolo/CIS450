using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerDecorator : PlayerBonus
{
    public override abstract float speed { get; set; }
    public override abstract int score { get; set; }
}
