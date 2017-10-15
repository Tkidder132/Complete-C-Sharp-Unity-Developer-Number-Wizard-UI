using UnityEngine;

public class NumberWizardController : MonoBehaviour
{
    int min, max, guess;
	// Use this for initialization
	void Start ()
    {
        StartGame();
	}

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    
    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        
        max++;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}