using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLooting : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        GameObject itemsGameObject = collider.gameObject;
        if (itemsGameObject.tag == "Lootable") {
            Destroy(itemsGameObject);
        }
    }
}
