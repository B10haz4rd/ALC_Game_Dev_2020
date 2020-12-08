using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject powerupPrefab;
    
    public GameObject enemyPrefab;

    public int enemyCount;

    public int waveNumber = 1;

    // Start is called before the first frame update

    //spawn enemy at a random position on the X and Z axis between positive and negative nine

    void Start()
    {
       SpawnEnemyWave(waveNumber);

       Instantiate(powerupPrefab,GenerateSpawnPosition(),powerupPrefab.transform.rotation);
    }

    //spawn an increasing number of enemies
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {

        float spawnPosX = Random.Range(-9, 9);

        float spawnPosZ = Random.Range(-9, 9);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

    // Update is called once per frame
    //generate an increasing number of enemies and start each wave with a new powerup
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0) { 
            waveNumber++; SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab,GenerateSpawnPosition(),powerupPrefab.transform.rotation);
            }
    }
}
