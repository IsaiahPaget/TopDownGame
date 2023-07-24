using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarController : MonoBehaviour
{
    float _maxHealth;
    float _currentHealth;
    Slider _slider;
    void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void SetHealth(float amount) {
        _currentHealth = amount;
        _slider.value = _currentHealth;
    }
    public void SetMaxHealth(float amount) {
        if (amount != 0 && amount >= 0 ) {
            _maxHealth = amount;
        }
        _currentHealth = _maxHealth;
        if (_slider != null) {
            _slider.maxValue = _maxHealth;
            _slider.value = _currentHealth;
        } else {
            Debug.Log(gameObject.name + " does not have a Slider component!");
        }
    }
}
