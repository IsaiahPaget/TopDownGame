using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLootDropper : MonoBehaviour
{
    [SerializeField] 
    Loot _loot;

    void OnDisable()
    {
        _loot.Drop(transform);
    }
}
