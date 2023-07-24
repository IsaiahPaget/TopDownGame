using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeStats : MonoBehaviour
{
    public float speed;
    public float maxHealth;
    public float currentHealth;

    void Awake() {
        currentHealth = maxHealth;
    }
}
