using System;

class Program
{

     public static bool quitGame = false;
     // DECLARING AS CLASS MEMBERS FOR ACCESS IN OTHER METHODS
     public static string secretWord;
     // 3. declares and instances wordState char array of the string.
     public static char[] wordState;
     public static string guessChoice;
     public static int startUnfilled;
     public static int remainingLetters;

     static void Main()
     {
          while(quitGame==false)
          {
               startUnfilled = 0;
               //  __  __    _    ___ _   _   __  __ _____ _   _ _   _ 
               // |  \/  |  / \  |_ _| \ | | |  \/  | ____| \ | | | | |
               // | |\/| | / _ \  | ||  \| | | |\/| |  _| |  \| | | | |
               // | |  | |/ ___ \ | || |\  | | |  | | |___| |\  | |_| |
               // |_|  |_/_/   \_\___|_| \_| |_|  |_|_____|_| \_|\___/
               Console.WriteLine("Welcome to Hangman.");
               Console.WriteLine("If you want to play the game, click (almost) any button.");
               Console.WriteLine($"If you want to quit the game, press 'q'");

               string mainMenuChoice = Console.ReadLine();
               if (mainMenuChoice == "q" || mainMenuChoice == "Q")
               {
                    quitGame=true;
               }
               //Clears up the menu before the game starts
               Console.Clear();

               // DECLARE AND INITIALIZE ALL WORDS IN GAME
               string[] actualWord = 
               {
                    "DELIVER", "ROCK", "ANIME", "STRAWMAN", "BERRY", 
                    "SEARCH", "GOOSE", "BLOOD", "GUTS", "PEACE"
               };

               // Initialize before gameplay method
               // Instances randomizer to wordPicker var
               Random wordPicker = new Random();
               // 1. Assigns a random value from the first index-position to the last index position of actualWord-array
               int randomPickerIndex = wordPicker.Next(actualWord.Length);
               // 2. Store the randomly selected word from actualWord array into secretWord
               secretWord = actualWord[randomPickerIndex];
               // 3. declares and instances wordState char array of the string.
               // Initial underscore contents, to be replaced upon correct input inside GameLoop.cs after "char letterInput"
               wordState = new char[secretWord.Length];
               for(int i = 0; i < wordState.Length; i++)
               {
                    wordState[i] = '_';
               }


               //  ____     _   __   __ _____ ____   _        _   __   __
               // / ___|   / \  |  \/  | ___  | _ \ | |      / \  \ \ / /
               // | |  _  / _ \ | |\/| |  _|  ||_) || |     / _ \  \ V / 
               // | |_| |/ ___ \| |  | | |___ | __/ | |__  / ___ \  | |  
               // \____/_/    \_\_|  |_|_____ |_|   |_____/_/   \_\ |_|
               
               GameLoop.HangmanGameplay();

          }
     }
}