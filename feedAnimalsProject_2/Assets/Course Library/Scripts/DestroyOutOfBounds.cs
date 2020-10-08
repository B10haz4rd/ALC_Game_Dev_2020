using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = -30.0f;
    public float lowerBound = 35.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > lowerBound)
        {
            Destroy(gameObject);
        }
    }
}