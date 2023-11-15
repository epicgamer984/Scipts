using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject[ ] animalPrefabs;
      private float spawnRangeX = 10;
      private float spawnRangeZ = -10;
      public float startDelay = 2;
      public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
