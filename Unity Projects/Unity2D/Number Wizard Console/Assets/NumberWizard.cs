using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max=1000;
    int min=1;
    int guess=500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max=1000;
        min=1;
        guess=500;
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please Pick a Number:");
        Debug.Log("The Highest Number you can peak is: " + max);
        Debug.Log("The Lowest Number you can peak is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up arrow key = Higher, Down arrow key = Lower, Enter = Correct");
        max++;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min=guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max=guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I got it!");
            StartGame();
        }
        
    }
    void NextGuess()
    {
        guess=(max+min)/2;
        Debug.Log("Is it higher or lower than..."+guess);
    }
}
