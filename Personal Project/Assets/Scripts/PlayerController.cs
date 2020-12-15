using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed of the player
    private float speed = 15.0f;

    //upper and lower bound limit
    private float zBound = 24;
    
    //right/left bound limit
    private float xRange = 24;

    //reference to the player's rigid body
    private Rigidbody playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        //the PLAYERRIGIDBODY means the component RIGIDBODY
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();

        //enemy should face toward the mouse
    }

    //Moves the player based on arrow key input
    void MovePlayer()
    {
        //controlls player movement based on keys pressed in correlation with the axis they are on the speed they can go and the directions they are allowed to travel.
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //prevent the player from leaving the top or bottom of the screen
    void ConstrainPlayerPosition()
    {
        //Placing bounds on the upward and downward directions.
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
         if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        //places boundry to the left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //places a boundry to the right
        if (transform.position.x > xRange)
        {
         transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
    }
}