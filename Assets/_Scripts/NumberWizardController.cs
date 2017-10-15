using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizardController : MonoBehaviour
{
    int min, max, guess, maxGuessesAllowed, guessAmount;

    public Text guessText;

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
        NextGuess();

        SetGuessText(guess.ToString());

        max++;
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessAmount++;
        SetGuessText(guess.ToString());

        if (guessAmount.Equals(maxGuessesAllowed))
        {
            SceneManager.LoadScene("Win");
        }
    }

    void SetGuessText(string guess)
    {
        guessText.text = guess.ToString();
    }
}