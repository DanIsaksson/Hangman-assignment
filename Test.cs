using System;

class Program
{
    static void Main()
    {
// My word collection (10 words long)


          bool quitGame = false;

          while(quitGame==false)
          {
//  __  __    _    ___ _   _   __  __ _____ _   _ _   _ 
// |  \/  |  / \  |_ _| \ | | |  \/  | ____| \ | | | | |
// | |\/| | / _ \  | ||  \| | | |\/| |  _| |  \| | | | |
// | |  | |/ ___ \ | || |\  | | |  | | |___| |\  | |_| |
// |_|  |_/_/   \_\___|_| \_| |_|  |_|_____|_| \_|\___/
               Console.WriteLine("Welcome to Hangman.");
               Console.WriteLine("If you want to play the game, click (almost) any button.");
               Console.WriteLine($"If you want to quit the game, press 'q'");

               string mainMenuChoice = Console.ReadLine()
               if (mainMenuChoice == "q" || mainMenuChoice == "Q")
               {
                    quitGame==true;
               }

               bool gameInProgress = true;
               //Clears up the menu before the game starts
               Console.Clear();


//  ____     _   __   __ _____ ____   _        _   __   __
// / ___|   / \  |  \/  | ___  | _ \ | |      / \  \ \ / /
// | |  _  / _ \ | |\/| |  _|  ||_) || |     / _ \  \ V / 
// | |_| |/ ___ \| |  | | |___ | __/ | |__  / ___ \  | |  
// \____/_/    \_\_|  |_|_____ |_|   |_____/_/   \_\ |_|
               while(gameInProgress==true)
               {
                    string[] actualWord = 
                    {
                         "DELIVER", "ROCK", "ANIME", "STRAWMAN", "BERRY", 
                         "SEARCH", "GOOSE", "BLOOD", "GUTS", "PEACE"
                    };

                    // Instances randomizer to wordPicker var
                    Random wordPicker = new Random();
                    // 1. Assigns a random value from the first index-position to the last index position of actualWord-array
                    int randomPickerIndex = wordPicker.Next(actualWord.Length);
                    // 2. Store the randomly selected word from actualWord array into secretWord
                    string secretWord = actualWord[randomPickerIndex];
                    // 3. declares and instances wordState char array of the string.
                    char[] wordState = new char[secretWord.Length];

                    // 🔍 CREATING THE MYSTERY PATTERN! 🔍
                    // This creates the "_ _ _ _" pattern that players see
                    // We're building it step by step so you understand every piece
                    Console.WriteLine("Your mystery word is:");
                    
                    // Initially prints the number of characters needed for the randomly picked secret word
                    string mysteryPattern = "";
                    for (int i = 0;  i < secretWord.Length; i++)
                    {
                         mysteryPattern += "_ ";
                    }
                    
                    Console.WriteLine(mysteryPattern);
                    Console.WriteLine("\n");
                    Console.WriteLine($"You have {secretWord.Length} letters to discover!");
                    Console.WriteLine();
                    
                    string wordGuess = "";
                    char letterGuess = "";

                    // NEW MODULE: FOR LOOP TO TEST INPUT VERSUS ARRAY CONTENTS
                    Console.WriteLine($"Would you like to guess the word or a letter?");
                    Console.WriteLine($"Enter 'W' if you want to guess the word, 'L' if you want to guess the ltter.");
                    
                    Console.WriteLine($"You have 10 tries.")
                    guessChoice = Console.ReadLine();


                    for(int i = 10; i > 0; i--)
                    {
                    
                         Console.WriteLine($"You have {i} attempts left.");
                         
                         if (guessChoice == "W" || guessChoice == "w")
                         {
                              Guessing.CompareStringLength();
                         }
                         else if (guessChoice == "L" || guessChoice == "l")
                         {
                              Guessing.GetValidLetter();
                              //  _____ _____ ____ _____ ___ _   _  ____    _    ____  ____      _ __   __
          //NEXT HERE         // |_   _| ____/ ___|_   _|_ _| \ | |/ ___|  / \  |  _ \|  _ \    / \\ \ / /
          //ADD LOGIC         //   | | |  _| \___ \ | |  | ||  \| | |  _  / _ \ | |_) | |_) |  / _ \\ V / 
                              //   | | | |___ ___) || |  | || |\  | |_| |/ ___ \|  _ <|  _ <  / ___ \| |  
                              //   |_| |_____|____/ |_| |___|_| \_|\____/_/   \_\_| \_\_| \_\/_/   \_\_|  
                              // ADD LOGIC FOR ARRAY COMPARISON vHERE
                         }

                         // GAME IS FINISHED, MENU OR QUIT CHOICE
                         Console.WriteLine($"You have run out of attempts.");
                         Console.WriteLine();
                         Console.WriteLine($"Enter 'q' if you want to quit the game.");
                         Console.WriteLine($"Press any other key to get back to the main menu.");
                         if(char.TryParse(Console.ReadLine(), out char endChoice))
                         {
                              return endChocie;
                         }
                         if(endChoice=="Q" || endChoice == "q");
                         {
                              quitGame = true;
                         }
                    } 
               }
          }
     }
}