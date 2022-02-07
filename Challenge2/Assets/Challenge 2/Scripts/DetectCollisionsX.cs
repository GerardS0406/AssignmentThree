using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Detects if ball and dog collide
 * If they do, score is increased
 */

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("DisplayScore").GetComponent<DisplayScore>().score++;
        Destroy(gameObject);
    }
}
