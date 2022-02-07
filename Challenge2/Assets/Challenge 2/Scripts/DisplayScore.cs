using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Gerard Lamoureux
 * Assignment Three
 * Updates the score UI.
 * If score >= 5, you win
 */

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Set up the reference to the Textbox component on this GameObject
        textbox = GetComponent<Text>();
        textbox.text = $"Score: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = $"Score: {score}";
        if(score >= 5)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().GameOver();
        }
    }
}