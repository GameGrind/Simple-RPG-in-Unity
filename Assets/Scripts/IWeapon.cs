using System.Collections.Generic;

using UnityEngine;

public interface IWeapon {
    List<BaseStat> Stats { get; set; }
    void PerformAttack();
    void PerformSpecialAttack();
}
