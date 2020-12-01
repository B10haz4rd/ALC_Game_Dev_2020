using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Start is called before the first frame update

    //spawn enemy at a random position on the X and Z axis between positive and negative nine

    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {

        float spawnPosX = Random.Range(-9, 9);

        float spawnPosZ = Random.Range(-9, 9);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
