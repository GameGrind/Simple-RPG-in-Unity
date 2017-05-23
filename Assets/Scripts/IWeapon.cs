using System.Collections.Generic;

using UnityEngine;

public interface IWeapon {
    List<BaseStat> Stats { get; set; }
    CharacterStats CharacterStats { get; set; }
    void PerformAttack();
    void PerformSpecialAttack();
}