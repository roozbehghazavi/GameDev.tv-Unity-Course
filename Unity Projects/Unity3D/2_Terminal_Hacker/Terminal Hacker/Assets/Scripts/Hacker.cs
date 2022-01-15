using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string password;
    string[] passwords1 = { "affarin", "bashtani", "baladi", "namir" };
    string[] passwords2 = { "bemir", "befrest", "mmd", "asb" };
    enum Screen { MainMenu,Password,Win};
    Screen currentScreen;

    void OnUserInput(string str)
    {
        if (str == "menu")
        {
            ShowMainMenu("Roozbeh");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(str);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(str);
        }
    }

    void RunMainMenu(string str)
    {
        bool isValidNumber = (str == "1" || str == "2");

        if(isValidNumber)
        {
            level = int.Parse(str);
            StartGame();
        }    

        else if (str == "007")
        {
            Terminal.WriteLine("Please select a level Mr Bond!");

        }

        else
        {
            Terminal.WriteLine("Please enter a valid option!");
        }
    }


    void StartGame()
    {
        currentScreen = Screen.Password;
        switch(level)
        {
            case 1:
                var randomIndex = UnityEngine.Random.Range(0, passwords1.Length);
                password = passwords1[randomIndex];
                break;
            case 2:
                var randomIndex2 = UnityEngine.Random.Range(0, passwords2.Length);
                password = passwords2[randomIndex2];
                break;
            default:
                Debug.Log("Invalid case");
                break;
        }
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("enter your passsword: ");
        Terminal.WriteLine("hint: " + password.Anagram());
    }

    void ShowMainMenu(string str)
    {
        currentScreen = Screen.MainMenu;
        password = "";
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome " + str);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for local library");
        Terminal.WriteLine("Press 2 for police station");
        Terminal.WriteLine("Enter your selection:");
        
    }
    void CheckPassword(string str)
    {
        if (str == password)
        {
            ShowWinMenu();
        }
        else
        {
            Terminal.WriteLine("Please Try again!");
        }
    }

    void ShowWinMenu()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();

    }

    void ShowLevelReward()
    {
        Terminal.WriteLine("Congrats! the password was correct");
        Terminal.WriteLine(@"
      _____
     |.---.|
     ||___||
     |+  .'| Roozbeh Ghazavi
     | _ _ |
     |_____/
");
        Terminal.WriteLine("Type 'menu' to return to the main menu");
    }

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Roozbeh");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
