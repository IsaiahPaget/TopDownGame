using UnityEngine;

public class FireBall : Spell {

    Transform _firePoint;

    Vector2 _direction;

    void Awake() {
        base._rb = GetComponent<Rigidbody2D>();
        _firePoint = GameObject.Find("FirePoint").transform;
        
    }
    void Start() {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 firePointPosition = new Vector2(_firePoint.position.x, _firePoint.position.y);
        _direction = mousePosition - firePointPosition;
        base._rb.velocity = _direction * base._speed;
    }
}