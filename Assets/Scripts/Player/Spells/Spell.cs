using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : ScriptableObject
{
    [SerializeField] protected float _damage;
    [SerializeField] protected float _speed;
    [SerializeField] protected GameObject _prefab;
    [SerializeField] protected float _duration;

    public float damage => _damage;
    public abstract void Cast();
}
