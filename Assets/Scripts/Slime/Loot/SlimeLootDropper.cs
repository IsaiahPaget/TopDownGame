using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLootDropper : MonoBehaviour
{

    [SerializeField] 
    Loot _loot;

    public void DropLoot() {
        _loot.Drop(transform);
    }
}
