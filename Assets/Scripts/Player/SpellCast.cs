using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCast : MonoBehaviour
{
    [SerializeField]
    Transform _firePoint;

    [SerializeField]
    Spell _spell;
    
    void OnFire() {
        Instantiate(_spell, _firePoint);
    }
}
