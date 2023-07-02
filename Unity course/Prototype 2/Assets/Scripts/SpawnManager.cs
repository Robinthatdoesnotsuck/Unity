using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimals()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 leftSpawnPos = new Vector3(-spawnRangeX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        Vector3 rightSpawnPos = new Vector3(spawnRangeX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));
        //animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 0, 0);
        //animalPrefabs[animalIndex].transform.Rotate(0, -90, 0, Space.World);
        Instantiate(animalPrefabs[animalIndex], leftSpawnPos, Quaternion.Euler(0, 90, 0));

        Instantiate(animalPrefabs[animalIndex], rightSpawnPos, Quaternion.Euler(0, -90, 0));
    }
}
