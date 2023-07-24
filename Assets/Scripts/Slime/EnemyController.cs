using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    SlimeStats _slimeStats;

    [SerializeField]
    float _followDistance;
    Rigidbody2D _rb;

    GameObject _target;

    Vector2 _direction;

    float _distance;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        GameObject target = GameObject.Find("Player");
        if (target != null) {
            _target = target;
        }

    }

    void Update() {
        _distance = Vector2.Distance(transform.position, _target.transform.position);
        _direction = _target.transform.position - transform.position;
        _direction.Normalize();
    }

    void FixedUpdate() {
        if (!_target) {
            Debug.Log(this.gameObject.name + " Has No Target"); return;
        }

        if (_distance < _followDistance) {
            _rb.velocity = (_direction * _slimeStats.speed * Time.deltaTime);
        } else {
            _rb.velocity = new Vector2(0, 0);
        }
    }
}
