using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerStats", menuName ="ScriptableObjects/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public float speed;
    public float maxHealth;
    public float currentHealth;
    
}
