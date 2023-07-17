using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallLifeTime : MonoBehaviour
{
    [SerializeField]
    float _durationInSeconds;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyFireBall", _durationInSeconds);    
    }

    void DestroyFireBall() {
        Destroy(gameObject);
    }
}
