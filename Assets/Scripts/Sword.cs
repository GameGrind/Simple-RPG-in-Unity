using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Sword : MonoBehaviour, IWeapon
{
    private Animator animator;
    public List<BaseStat> Stats { get; set; }
    public CharacterStats CharacterStats { get; set; }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PerformAttack()
    {
        animator.SetTrigger("Base_Attack");
        CalculateDamageValue();
    }

    public void PerformSpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
    }

    int CalculateDamageValue()
    {
        // Completely arbitrary formula
        int damage = Convert.ToInt32(((CharacterStats.stats[0].GetCalculatedStatValue() * 2.5f) / 2) * (UnityEngine.Random.Range(0.5f, 1f)));
        damage += CalculateCriticalHit(damage);
        Debug.Log("damage is: " + damage);
        return damage;
    }

    int CalculateCriticalHit(int damage)
    {
        if (UnityEngine.Random.value <= ((40f/100f) * .45f))
        {
            return Convert.ToInt32(damage + ((damage * UnityEngine.Random.Range(.65f, .9f)) / 2));
        }

        return 0;
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            col.GetComponent<IEnemy>().TakeDamage(CharacterStats.stats[0].GetCalculatedStatValue());
        }
    }


}
