using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string password;
    string[] passwords = { "affarin", "bashtani", "baladi", "namir" };
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
        if (str == "1")
        {
            level = 1;
            password = passwords[1];
            StartGame();
        }

        else if (str == "2")
        {
            level = 2;
            password = passwords[2];
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
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your passsword: ");
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
            Terminal.WriteLine("Congrats! the password was correct");
        }
        else
        {
            Terminal.WriteLine("Please Try again!");
        }
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
