using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpellCast : MonoBehaviour
{
    [SerializeField] private Spell spell;

    public void OnFire(InputValue value)
    {
        spell.Cast();
    }
}
