using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBarController : MonoBehaviour
{
    [SerializeField]
    float _maxHealth;
    float _currentHealth;

    [SerializeField]
    HealthBarController _healthBarController;
    void Awake()
    {
        _healthBarController.SetMaxHealth(_maxHealth);        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        _currentHealth -= 1;
        _healthBarController.SetHealth(_currentHealth);
    }
}
