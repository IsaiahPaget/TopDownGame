using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCollisions : MonoBehaviour
{
    [SerializeField]
    SlimeLootDropper _lootDropper;

    [SerializeField]
    SlimeStats _slimeStats;

    [SerializeField]
    SlimeExplosionParticles _particles;

    SpellStats spellStats;
    void OnTriggerEnter2D(Collider2D collider) {
        spellStats = collider.GetComponent<SpellStats>();
        if (spellStats != null) {
            TakeDamageFromSpells();
        }

    }
    void Die() {
        Instantiate(_particles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void TakeDamageFromSpells() {
        _slimeStats.currentHealth -= spellStats.spell.damage;
            if (_slimeStats.currentHealth <= 0) {
                _lootDropper.DropLoot();
                Die();
            }
    }
}
