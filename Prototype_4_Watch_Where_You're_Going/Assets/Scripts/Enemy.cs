using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;

    private Rigidbody enemyRB;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //retrieve the ENEMYRIGIDBODY and the PLAYER
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //move toward the player by subracting the distance between the PLAYER and the ENEMY multiplied by the SPEED variable

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRB.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
