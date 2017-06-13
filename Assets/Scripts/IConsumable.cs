using UnityEngine;
using System.Collections;

public interface IConsumable {
    void Consume();
    void Consume(CharacterStats stats);
}
