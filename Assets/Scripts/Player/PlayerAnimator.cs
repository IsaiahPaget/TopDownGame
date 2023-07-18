using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimator : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _animator;
    const string PLAYER_IDLE = "Idle";
    const string PLAYER_WALK_BACK = "WalkBack";
    const string PLAYER_WALK_FORWARD = "WalkForward";
    const string PLAYER_WALK_RIGHT = "WalkRight";
    const string PLAYER_WALK_LEFT = "WalkLeft";

    void Awake()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (_rb.velocity.Equals(new Vector2(0,0))) {
            _animator.Play(PLAYER_IDLE);
        }
        if (_rb.velocity.x > 0) {
            if (_rb.velocity.y > 0) {
                _animator.Play(PLAYER_WALK_BACK);

            }
            else if (_rb.velocity.y < 0) {
                _animator.Play(PLAYER_WALK_FORWARD);

            }
            else {
            _animator.Play(PLAYER_WALK_RIGHT);
            }  
        } 
        
        if (_rb.velocity.x < 0) {
            if (_rb.velocity.y > 0) {
                _animator.Play(PLAYER_WALK_BACK);

            }
            else if (_rb.velocity.y < 0) {
                _animator.Play(PLAYER_WALK_FORWARD);

            }
            else {
                _animator.Play(PLAYER_WALK_LEFT);
            }  
        }

        if (_rb.velocity.y > 0) {
            _animator.Play(PLAYER_WALK_BACK);

        }

        if (_rb.velocity.y < 0) {
            _animator.Play(PLAYER_WALK_FORWARD);

        }  
    }
}
