using UnityEngine;

public abstract class Loot : ScriptableObject {
    abstract public void Drop(Transform whereToDrop);
}