using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 10.0f;
    
    public float xRange = 10;
    
    public GameObject projectilePrefab;
    
    // Update is called once per frame
    void Update()
    {
        //Collect Input on Horizontal controlls
        horizontalInput = Input.GetAxis("Horizontal");
        //allows the player to move right and left
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //keeps the player in bounds left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //places a boundry to the right
        if (transform.position.x > xRange)
        {
         transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
        //launch projectile from player
        Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
        }
    }
}
