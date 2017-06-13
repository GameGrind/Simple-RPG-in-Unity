using UnityEngine;
using System.Collections;
using System;

public class UIEventHandler : MonoBehaviour {

    public static event ItemEventHandler OnItemAddedToInventory;
    public delegate void ItemEventHandler(Item item);

    public static void ItemAddedToInventory(Item item)
    {
        OnItemAddedToInventory(item);
    }
}
