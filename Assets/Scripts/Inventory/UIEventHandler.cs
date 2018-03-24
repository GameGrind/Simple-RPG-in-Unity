using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class UIEventHandler : MonoBehaviour {

    public delegate void ItemEventHandler(Item item);
    public static event ItemEventHandler OnItemAddedToInventory;
    public static event ItemEventHandler OnItemEquipped;

    public delegate void PlayerHealthEventHandler(int currentHealth, int maxHealth);
    public static event PlayerHealthEventHandler OnPlayerHealthChanged;

    public delegate void StatsEventHandler();
    public static event StatsEventHandler OnStatsChanged;

    public delegate void PlayerLevelEventHandler();
    public static event PlayerLevelEventHandler OnPlayerLevelChange;

    public static void ItemAddedToInventory(Item item)
    {
        if (OnItemAddedToInventory != null)
            OnItemAddedToInventory(item);
    }

    public static void ItemAddedToInventory(List<Item> items)
    {
        if (OnItemAddedToInventory != null)
        {
            foreach(Item item in items)
            {
                OnItemAddedToInventory(item);
            }
        }
    }

    public static void ItemEquipped(Item item)
    {
        if (OnItemEquipped != null)
            OnItemEquipped(item);
    }

    public static void HealthChanged(int currentHealth, int maxHealth)
    {
        if (OnPlayerHealthChanged != null)
            OnPlayerHealthChanged(currentHealth, maxHealth);
    }

    public static void StatsChanged()
    {
        if (OnStatsChanged != null)
            OnStatsChanged();
    }

    public static void PlayerLevelChanged()
    {
        if (OnPlayerLevelChange != null)
            OnPlayerLevelChange();
    }
}
