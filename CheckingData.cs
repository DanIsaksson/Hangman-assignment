public class CheckingData
{

     public static void CompareSWordString()
     {
          
          Console.WriteLine("Enter the word you want to check: ");
          string guessingWord = Console.ReadLine();
          if(guessingWord == Program.secretWord)
          {
               Console.WriteLine("Congratulations, you guessed correctly!");
               Console.WriteLine("Press 'Enter' to return to the main menu.");
               Console.ReadLine();
               //Sends us back to the start of the main game while loop.
          }
          else 
          {
               Console.WriteLine("Oops. That's wrong, it looks like your hangman is getting his life back together for the hanging.");
               Console.WriteLine("A bodypart has been added.");
          /* ADD LOGIC FOR +BODYPART TO HANGMAN. YOU HAVE A TOTAL OF 10 TRIES, INCLUDING SUCCESSFUL GUESSES. 
          THIS JUST ADDS AN ADDITIONAL LIMIT ON HOW MAN FAILS YOU CAN HAVE BEFORE 10 TRIES ARE UP.
           +---+
           |   |
           O   |  <- Add head on first wrong guess
          /|\  |  <- Add body and arms on 2nd-4th wrong guesses
          / \  |  <- Add legs on 5th-6th wrong guesses
               |
          =========
          */
          }
     }

     public static char GetValidLetter()
     {
     Console.Write("Enter a letter: ");
     string parsingLetterInput = Console.ReadLine();
     if (char.TryParse(parsingLetterInput, out char letter))
     {
          return letter;
     }
     Console.WriteLine("Invalid input. Please enter a single letter.");
     return GetValidLetter(); // Calls itself until valid input
     }

}