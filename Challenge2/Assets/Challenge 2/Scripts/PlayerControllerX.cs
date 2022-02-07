using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Handles dog spawning/delay
 */

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeElapsed = 0.0f;
    private float spawnDelay = 1.5f;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeElapsed > spawnDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeElapsed = 0;
        }
    }
}
