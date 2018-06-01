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
        StartGame();
    }

    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Howdy Ya'll! Welcome to Number Wizard!");
        Debug.Log("Pick a number!");
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Up Key = Higher, Push Down = Lower, Enter = Correct Guess:");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Haha! Got it! Your number was: " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Dang! Okay, how about lower or higher than: " + guess);
    }
}
