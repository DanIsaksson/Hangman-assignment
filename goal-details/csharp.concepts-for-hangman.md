# C# CONCEPTS FOR HANGMAN ASSIGNMENT

This document outlines the key C# concepts from your Week 7 lecture that are essential for building the Hangman game.

### **Core Concepts**
*   **Variables:** You will need variables to store the state of your game.
    *   `string secretWord`: To hold the word the player needs to guess.
    *   `int guessesLeft = 10;`: To track the number of remaining guesses.
    *   `int remainingLetters`: To track unfilled positions in the word.
    *   `bool hasWon = false;`: A flag to know when the game loop should end.

### **Compound Assignment Operators** *(Recently Learned)*
*   **`-= 1` vs. `= variable - 1`:** These are equivalent! 
    ```csharp
    remainingLetters -= 1;      // Shorthand (preferred)
    remainingLetters = remainingLetters - 1;  // Expanded form
    ```
*   **Other compound operators:** `+=`, `*=`, `/=`, `%=`
*   **Why use compound operators:** More concise, efficient, and commonly used in professional code.

### **Data Structures (Arrays and Lists)**
Your lecture materials covered Arrays and Lists, which are both critical for this assignment.

*   **`string[]` (String Array):** Use this to store the pool of possible secret words.
    *   **Requirement:** "The secret word should be randomly chosen from an array of Strings."
    *   **Example:** `string[] wordBank = { "lexicon", "csharp", "developer", "hangman", "programming" };`

*   **`char[]` (Character Array):** Use this to store and display the current state of the guessed word.
    *   **Requirement:** "The correct letters should be put inside a char array. Unrevealed letters need to be represented by a lower dash (_)."
    *   **Example:**
        ```csharp
        string secretWord = "hello";
        char[] displayWord = new char[secretWord.Length];
        for (int i = 0; i < displayWord.Length; i++)
        {
            displayWord[i] = '_';
        }
        // displayWord is now [ '_', '_', '_', '_', '_' ]
        ```

*   **`List<char>` (List of Characters):** A `List` is perfect for keeping track of the letters the player has already guessed because its size can change dynamically.
    *   **Requirement:** "The incorrect letters the player has guessed, should be kept track of..."
    *   **From your lecture:** `List` is a "more convenient method" for collections where you add/remove items.
    *   **Example:**
        ```csharp
        List<char> incorrectGuesses = new List<char>();
        incorrectGuesses.Add('q'); // Add an incorrect guess
        
        // You can also use a List for all guessed letters to check for duplicates
        List<char> allGuessedLetters = new List<char>();
        if (allGuessedLetters.Contains('a')) {
            Console.WriteLine("You already guessed that letter!");
        }
        ```

### **Classes and Objects**
Your lecture focused on "Deepening our understanding of Classes & Objects." The `Random` class is a perfect example.

*   **`Random` Class:** Used to select a word from your `wordBank` array.
    *   **From your lecture:** `Random chanceObject = new Random();` and `chanceObject.Next(100);`
    *   **How to use it:** Create one `Random` object for your whole program. Use its `.Next(int maxValue)` method to get a random index for your array.
    *   **Example:**
        ```csharp
        string[] wordBank = { "apple", "banana", "cherry" };
        Random random = new Random();
        int randomIndex = random.Next(wordBank.Length); // Gets a number between 0 and 2
        string secretWord = wordBank[randomIndex];
        ```

### **Control Flow**
*   **`while` Loop:** The best choice for the main game loop. It should continue as long as the player has guesses left AND hasn't won the game.
    ```csharp
    while (guessesLeft > 0 && !hasWon)
    {
        // Game logic goes here...
    }
    ```
*   **`if / else` Statements:** Essential for processing a player's guess.
    *   Is the guess a single letter or a whole word?
    *   Is the guessed letter in the secret word?
    *   Has the letter already been guessed?
*   **`for` Loop:** Use this to iterate through the secret word to check for a guessed letter and to update your `char[]` display.

### **Console Interaction**
*   **Output:** `Console.WriteLine()` to display the game state (the `_ _ _` word, incorrect guesses, remaining guesses).
*   **Input:** `Console.ReadLine()` to get the user's guess as a string.

### **String and Character Manipulation**
*   **`.Length`:** Use `input.Length` to determine if the player guessed a single letter or a whole word.
*   **`.ToLower()`:** It's good practice to convert both the player's input and the secret word to the same case (e.g., lowercase) to avoid issues like guessing 'a' when the word contains 'A'. `string guess = Console.ReadLine().ToLower();`
*   **`string.Contains(char)`:** An easy way to check if the secret word contains the guessed letter. `if (secretWord.Contains(guessedLetter))`
*   **String Indexing `secretWord[i]`:** To access a specific character in the secret word when updating your display array.