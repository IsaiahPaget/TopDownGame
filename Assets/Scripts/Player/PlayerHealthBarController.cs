using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBarController : MonoBehaviour
{
    [SerializeField]
    PlayerStats _playerStats;

    [SerializeField]
    HealthBarController _healthBarController;
    void Awake() {
        _playerStats.currentHealth = _playerStats.maxHealth;
    }
    void Start()
    {
        _healthBarController.SetMaxHealth(_playerStats.maxHealth);        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        _playerStats.currentHealth -= 1;
        _healthBarController.SetHealth(_playerStats.currentHealth);
    }
}
