﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5,-10);
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
       //Makes the Camera follow the player's position with an offset
       transform.position = player.transform.position + offset;
    }
}
