using UnityEngine;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour {
    public PlayerWeaponController playerWeaponController;
    public Item sword;

    void Start()
    {
        playerWeaponController = GetComponent<PlayerWeaponController>();
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(6, "Power", "Your power level."));
        sword = new Item(swordStats, "sword");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            playerWeaponController.EquipWeapon(sword);
        }
    }
}
