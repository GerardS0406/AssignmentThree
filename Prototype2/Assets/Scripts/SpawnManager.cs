using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Handles Animal Spawns
 */

public class SpawnManager : MonoBehaviour
{
    //drag prefabs to spawn into array in inspector
    public GameObject[] prefabsToSpawn;

    private float xbounds = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;

    void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //3 seconds before first prefab spawns
        yield return new WaitForSeconds(3f);
        while(!healthSystem.gameOver)
        {
            //Spawns prefab
            SpawnRandomPrefab();

            float randomDelay = Random.Range(1.5f, 3.0f);

            //Wait 1.5 seconds before continuing the while loop
            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }
    void SpawnRandomPrefab()
    {
        //pick random animal
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate a random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xbounds, xbounds), 0, spawnPosZ);

        //Spawn the randomly selected prefab
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
