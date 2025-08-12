public class Parsing
{
     string CompareStringLength(string secretWord)
     {
          Console.WriteLine("Enter the word you want to check: ");
          string word = Console.ReadLine();
          if (word == secretWord)
          {
               Console.WriteLine("Congratulations, you guessed correctly!");
               Console.WriteLine("Press any button to return to the main menu.");
               Console.ReadLine();
               //Sends us back to the start of the main game while loop.
               gameInProgress = false;
          }
     }

     char GetValidLetter()
     {
     Console.Write("Enter a letter: ");
     if (char.TryParse(Console.ReadLine(), out char letter))
     {
          return letter;
     }
     Console.WriteLine("Invalid input. Please enter a single letter.");
     return GetValidLetter(); // Calls itself until valid input
     }

}