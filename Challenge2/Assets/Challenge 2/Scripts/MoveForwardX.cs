using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Handles movement of ball and dog
 */

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
