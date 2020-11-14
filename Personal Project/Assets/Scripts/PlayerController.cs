using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed of the player
    private float speed = 10.0f;
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
        //controlls player movement based on keys pressed in correlation with the axis they are on the speed they can go and the directions they are allowed to travel.
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
}