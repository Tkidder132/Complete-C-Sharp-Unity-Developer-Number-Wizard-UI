using UnityEngine;

public class NumberWizardController : MonoBehaviour
{
    int min, max, guess;
	// Use this for initialization
	void Start ()
    {
        StartGame();
	}

	// Update is called once per frame
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            PrintGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            PrintGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }
    
    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        print("Welcome to Number Wizard!");
        print("Pick a number in your head, but don't tell me!");

        print("The lowest number you can choose is: " + min);
        print("The highest number you can pick is : " + max);
        max++;

        PrintGuess();
    }

    void PrintGuess()
    {
        print("Is your number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal.");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}