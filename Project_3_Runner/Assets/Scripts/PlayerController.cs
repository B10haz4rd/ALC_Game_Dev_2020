using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float jumpForce;

    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //when the space bar is pressed force the Player to go up.
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //when my game object's compare tag is on the ground than my player is on the ground, OTHERWISE if the  game object interacts with a obstacle then LOG "Game Over!"
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

        }else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }
}
