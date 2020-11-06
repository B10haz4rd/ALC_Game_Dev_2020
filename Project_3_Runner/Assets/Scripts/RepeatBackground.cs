using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //set our cordinates on vector three to start position
    private Vector3 startPos;

    private float backgroundWidth;

    // Start is called before the first frame update
    void Start()
    {
       //our starting position equals our transform position
        startPos = transform.position;

        //backgroundwidth equals the width of my background divided by two
        backgroundWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {   
        //when the background of my scene hits a point that is less than that of my original start position then the background reverts back to it's original position
        if(transform.position.x < startPos.x - backgroundWidth)
        {
            transform.position = startPos;
        }
    }
}
