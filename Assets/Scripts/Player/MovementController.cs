using UnityEngine;
using UnityEngine.InputSystem;
public class MovementController : MonoBehaviour
{
    [SerializeField]
    float _speed;

    Vector2 _movement;

    Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * _speed * Time.deltaTime);
    }

    void OnMove(InputValue value) {
        _movement = value.Get<Vector2>();
    }
}
