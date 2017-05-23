using UnityEngine;
using System.Collections;

public class PlayerWeaponController : MonoBehaviour {
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    Transform spawnProjectile;
    IWeapon equippedWeapon;
    CharacterStats characterStats;

    void Start()
    {
        spawnProjectile = transform.FindChild("ProjectileSpawn");
        characterStats = GetComponent<CharacterStats>();
    }

    public void EquipWeapon(Item itemToEquip)
    {
        if (EquippedWeapon != null)
        {
            characterStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }


        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug), 
            playerHand.transform.position, playerHand.transform.rotation);
        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
        if (EquippedWeapon.GetComponent<IProjectileWeapon>() != null)
            EquippedWeapon.GetComponent<IProjectileWeapon>().ProjectileSpawn = spawnProjectile;
        
        EquippedWeapon.transform.SetParent(playerHand.transform);
        
        characterStats.AddStatBonus(itemToEquip.Stats);
        equippedWeapon.CharacterStats = characterStats;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            PerformWeaponAttack();
        if (Input.GetKeyDown(KeyCode.Z))
            PerformWeaponSpecialAttack();
    }

    public void PerformWeaponAttack()
    {
        equippedWeapon.PerformAttack();
    }
    public void PerformWeaponSpecialAttack()
    {
        equippedWeapon.PerformSpecialAttack();
    }
}
