﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;


    // Update is called once per frame
    void Update()
    {
        //allows you to controll the rotation of the camera
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}

