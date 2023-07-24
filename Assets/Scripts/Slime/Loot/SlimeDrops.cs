using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SlimeDropsSO", menuName ="ScriptableObjects/SlimeDropsSo")]
public class SlimeDrops : Loot
{
    [SerializeField]
    GameObject _item;

    public override void Drop(Transform transform)
    {
        Instantiate(_item, transform.position, Quaternion.identity);
    }
}
