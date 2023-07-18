using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject _slime;

    [SerializeField]
    float _spawnRate;
    void Start() {
        Spawn();
    }

    void Spawn() {
        Instantiate(_slime, transform.position, Quaternion.identity);
        Invoke("Spawn", _spawnRate);
        if (_spawnRate > 1f) {
            _spawnRate *= .9f;
        }
    }
}
