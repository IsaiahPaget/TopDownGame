using UnityEngine;
using UnityEngine.InputSystem;
public class MovementController : MonoBehaviour
{
    [SerializeField]
    PlayerStats _playerStats; 

    Vector2 _movement;

    Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.velocity = _movement * _playerStats.speed * Time.deltaTime;
    }

    void OnMove(InputValue value) {
        _movement = value.Get<Vector2>();
        _movement.Normalize();
    }
}
