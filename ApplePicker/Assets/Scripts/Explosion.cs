using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    float lingerTime = 0.66f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", lingerTime);
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
