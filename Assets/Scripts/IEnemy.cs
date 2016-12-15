using UnityEngine;
using System.Collections;

public interface IEnemy
{
    void TakeDamage(int amount);
    void PerformAttack();
}
