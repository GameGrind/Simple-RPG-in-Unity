using UnityEngine;
using System.Collections;

public class PickupItem : Interactable {
    
    public override void Interact()
    {
        Debug.Log("Interacting with Item!");
    }
}
