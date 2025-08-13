public class GameLoop
{      
     public static void HangmanGameplay()
     {
          // This creates the "_ _ _ _" pattern that players see
          // We're building it step by step so you understand every piece
          Console.WriteLine("Your mystery word is: ");
          
          // Initially prints the number of characters needed for the randomly picked secret word
          Console.WriteLine(Program.wordState);

          Console.WriteLine("\n");

          for(int i=0; i<Program.secretWord.Length; i++)
          {
               if(Program.wordState[i]=='_')
               {
                    Program.startUnfilled += 1;
               }
          }
          Program.remainingLetters = Program.startUnfilled;
          Program.startUnfilled = 0;

          // ADD LOGIC TO DISCOVER REMAINING _ INSIDE Program.wordState. For loop perhaps?
          Console.WriteLine($"You have {Program.remainingLetters} letters to discover!");
          Console.WriteLine();
          
          string wordGuess = "";
          char letterInput;

          // NEW MODULE: FOR LOOP TO TEST INPUT VERSUS ARRAY CONTENTS
          Console.WriteLine($"Would you like to guess the word or a letter?");
          Console.WriteLine($"Enter 'W' if you want to guess the word, 'L' if you want to guess the ltter.");
          
          Console.WriteLine($"You have 10 tries.");
          Program.guessChoice = Console.ReadLine();

          // GAME LOOP FOR 10 ATTEMPTS
          for(int i = 10; i > 0; i--)
          {
               
               Console.WriteLine($"You have {i} attempts left.");
               Console.WriteLine(Program.wordState);
               
               if (Program.guessChoice == "W" || Program.guessChoice == "w")
               {
                    CheckingData.CompareSWordString();
               }
               // LOGIC FOR CHECKING LETTER AGAINST SECRET WORD CHARACTERS
               else if (Program.guessChoice == "L" || Program.guessChoice == "l")
               {
                    letterInput = CheckingData.GetValidLetter();
                    for(int a = 0; a < Program.secretWord.Length; a++)
                    {
                         if (letterInput == Program.secretWord[a])
                         {
                              Program.wordState[a] = letterInput;
                              Program.remainingLetters -= 1;
                              Console.WriteLine(Program.wordState);
                              Console.WriteLine();
                         }

                         if (Program.remainingLetters <= 0)
                         {
                              PlayerWins(); //Add method, unimplemented thus far.
                         }
                    }
               }
          }

          // GAME IS FINISHED, MENU OR QUIT CHOICE
          Console.WriteLine($"You have run out of attempts.");
          Console.WriteLine();
          Console.WriteLine($"Enter 'q' if you want to quit the game.");
          Console.WriteLine($"Press any other key to get back to the main menu.");
          if(char.TryParse(Console.ReadLine(), out char endChoice))
          {
               if(endChoice=='Q' || endChoice == 'q')
               {
                    Program.quitGame = true;
               }
          }
     }

     public static void PlayerWins()
     {
          Console.Clear();
          Console.WriteLine("Congratulations!");
          Console.WriteLine("You have uncovered the whole word and saved the hanging man. Phew. Good work!");
          
          Console.WriteLine();
          Console.WriteLine("If you want to play the game again, press 'R', otherwise press any other key to quit the game.");

          string afterWinChoice = Console.ReadLine();
          if(afterWinChoice != "R" || afterWinChoice != "r")
          {
               Program.quitGame = true;
          }
     }

}