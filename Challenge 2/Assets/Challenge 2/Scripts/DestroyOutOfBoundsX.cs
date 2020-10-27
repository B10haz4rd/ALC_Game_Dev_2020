using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //edges of where I want the dogs to vanish
    private float leftLimit = -20f;
    private float bottomLimit = -5f;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale = 0f;
        }

    }
}
