using UnityEngine;
using System.Collections;
using System;

public class PotionLog : MonoBehaviour, IConsumable
{
    public void Consume()
    {
        Debug.Log("You drank a swig of the potion. Cool!");
        Destroy(gameObject);
    }

    public void Consume(CharacterStats stats)
    {
        Debug.Log("You drank a swig of the potion. Rad!");
    }
}
