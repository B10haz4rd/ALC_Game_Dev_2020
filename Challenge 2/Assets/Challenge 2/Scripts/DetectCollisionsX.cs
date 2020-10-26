using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //when the bounding box of the dog hits the bounding box of a ball the ball is destroyed
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
