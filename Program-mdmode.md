using System;

class Program
{
    static void Main()
    {
// My word collection (10 words long)
        string[] actualWord = {
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
        
        Console.WriteLine("🌟 Welcome to YOUR Hangman Game! 🌟");
        Console.WriteLine();

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
        
        // Debug info (we'll remove this in the final version)
        Console.WriteLine($"Debug: The secret word is '{secretWord}'");
        Console.WriteLine("(Players won't see this debug info!)");
        Console.WriteLine();
        Console.WriteLine("🎉 Your mystery word display is working perfectly! 🎉");
        
        Console.WriteLine("Press any key to celebrate this victory...");
        Console.ReadKey();
    }
}