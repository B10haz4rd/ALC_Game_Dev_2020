using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{   
    private float speed = 15;

    private PlayerController playerControllerScript;

    private float leftBound = -15;

    void Start()
    {
        //my PLAYERCONTROLLERSCRIPT is equal to the Player
        playerControllerScript = GameObject.Find("Player").GetComponent < PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            //move whatever object this script is applied to, to the left.
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //destroy objects that leave the screen
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }  
}
