using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText;

    public Button restartButton;

    public GameObject titleScreen;

    public bool isGameActive;

    private int score;

    private float spawnRate = 1.0f;

    
    //when the mouse is clicked down on an object, that object is deleted.
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    
    //when something collides with the object below the screen and is triggerd, delete it.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    //spawning algorithm
    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0,targets.Count);
            Instantiate(targets[index]);
        }
        
    }
        //assists in the growth of our score
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //causes the game over screen to come on.
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
    //game restarts when a thing is pressed.
    public void RestartGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //gives some "settings" that need to present when the game begins.
    public void StartGame(int difficulty)
    {
        isGameActive = true;

        StartCoroutine(SpawnTarget());

        UpdateScore(0);

        score = 0;

        spawnRate /= difficulty;

        titleScreen.gameObject.SetActive(false);
    }
    
}
