using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    //upper and lower bound limit
    private float zBound = 24;
    
    //right/left bound limit
    private float xRange = 24;

    //reference to the player's rigid body
    private Rigidbody playerRb;

    //the center of the board
    private GameObject focalPoint;
    
    //speed of the player
    public float speed = 5.0f;


    public GameObject projectilePrefab;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("player was beaten");
        }
    }
}