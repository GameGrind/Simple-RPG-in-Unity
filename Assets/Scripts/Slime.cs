using UnityEngine;
using System.Collections;
using System;

public class Slime : MonoBehaviour, IEnemy
{
    public float currentHealth, power, toughness;
    public float maxHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void PerformAttack()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
