using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCollisions : MonoBehaviour
{
    [SerializeField]
    SlimeExplosionParticles _particles;
    void OnTriggerEnter2D(Collider2D collider) {
        Instantiate(_particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
