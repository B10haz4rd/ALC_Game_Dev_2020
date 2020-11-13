using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private Animator playerAnim;

    public float jumpForce;

    public float gravityModifier;

    public bool isOnGround = true;

    public bool gameOver = false;

    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;

    public AudioClip crashSound;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        playerAnim = GetComponent<Animator>();

        Physics.gravity *= gravityModifier;

        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //when the space bar is pressed force the Player to go up. Animate the upward movement
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            dirtParticle.Stop();

            playerAnim.SetTrigger("Jump_trig");

            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //when my game object's compare tag is on the ground than my player is on the ground, OTHERWISE if the  game object interacts with a obstacle then LOG "Game Over!" and play a the DEATH ANIMATION and play the CRASH sound
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            dirtParticle.Play();

        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");

            gameOver = true;
            
            playerAnim.SetBool("Death_b", true);

            playerAnim.SetInteger("DeathType_int", 1);

            explosionParticle.Play();

            dirtParticle.Stop();

            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
