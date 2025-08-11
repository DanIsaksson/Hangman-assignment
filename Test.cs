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
        // Assigns a random value from the first index-position to the last index position of actualWord-array
        int randomPickerIndex = wordPicker.Next(actualWord.Length);
        
        // Store the randomly selected word from actualWord array into guessWord
        string secretWord = actualWord[randomPickerIndex];
        
        // declares and instances wordState char array of the string.
        char[] wordState = new char[secretWord.Length];
        
        Console.WriteLine("🌟 Welcome to YOUR Hangman Game! 🌟");
        Console.WriteLine("🎯 Your game has secretly chosen a word for you to guess!");
        Console.WriteLine();

        // Let's prove the random selection works (we'll hide this later)
        Console.WriteLine($"Debug info: Your game picked word #{randomPickerIndex + 1}: {guessWord}");
        Console.WriteLine("(In the real game, this will be hidden!)");
        Console.WriteLine();
        Console.WriteLine("✨ Your random word picker is working perfectly! ✨");
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
