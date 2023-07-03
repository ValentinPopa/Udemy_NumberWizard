using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxValue = 1000;
    int minValue = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Application.targetFrameRate = 100;

        maxValue = 1000;
        minValue = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number, don't tell me what it is and I'll have to guess it");
        Debug.Log("The lowest number you can pick is: " + minValue);
        Debug.Log("The highest number you can pick is: " + maxValue);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push down = Lower, Push Enter = Correct");
        maxValue = maxValue + 1;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            minValue = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice job!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxValue + minValue) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
