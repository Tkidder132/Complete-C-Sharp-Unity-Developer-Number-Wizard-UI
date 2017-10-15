using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberWizardController : MonoBehaviour
{
    int min, max, guess, maxGuessesAllowed, guessAmount;
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
        maxGuessesAllowed = 10;
        guessAmount = 0;

        min = 1;
        max = 1000;
        guess = 500;
        
        max++;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessAmount++;

        if (guessAmount.Equals(maxGuessesAllowed))
        {
            SceneManager.LoadScene("win");
        }
    }
}