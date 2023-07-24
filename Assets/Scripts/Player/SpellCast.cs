using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCast : MonoBehaviour
{
    [SerializeField]
    Spell _spell;

    public void OnFire(InputValue value)
    {
        _spell.Cast();
    }
}
