using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    [SerializeField]
    protected float _damage;

    [SerializeField]
    protected float _speed;

    protected Rigidbody2D _rb;

}
