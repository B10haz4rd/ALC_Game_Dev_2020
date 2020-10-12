using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Move Speed of the Game Object
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        //moves the object forward across the desert
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
