using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{   
    private float speed = 15;
    // Update is called once per frame
    void Update()
    {
        //move whatever object this script is applied to, to the left.
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
