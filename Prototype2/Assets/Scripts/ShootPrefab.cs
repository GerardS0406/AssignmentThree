using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Handles food shooter
 */

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
