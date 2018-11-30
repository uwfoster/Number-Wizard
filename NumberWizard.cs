using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Hello Gamer! Welcome to Number Wizard!");
        Debug.Log("Choose a number, and DO NOT tell me what it is!!");
        Debug.Log("The highest number can be no more than: " + max);
        Debug.Log("And the lowest number you can pick is: " + min);
        Debug.Log("Now, tell me if your number is higher or lower than " + guess);
        Debug.Log("Press the Up arrow = for Higher, Push the Down arrow = for Lower, and press Enter if my guess is = Correct");
        max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is is higher or lower than " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Eureka!!!! I guessed your number!!!!");
        }

    }
}
