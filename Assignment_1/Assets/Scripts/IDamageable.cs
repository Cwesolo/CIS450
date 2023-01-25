using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damgeAmt);
    void RegenHealth(int regenAmt);
}
