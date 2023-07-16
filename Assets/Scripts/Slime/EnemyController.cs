using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    float _speed;

    [SerializeField]
    float _followDistance;
    Rigidbody2D _rb;

    [SerializeField]
    GameObject _target;

    Vector2 _direction;

    float _distance;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
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
            _rb.transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        }
    }
}
