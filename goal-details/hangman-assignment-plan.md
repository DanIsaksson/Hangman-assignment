# HANGMAN GAME - DEVELOPMENT PLAN

This plan breaks down the Hangman assignment into logical steps. Follow this guide to build your application.

## 1. Project Setup & Initial Variables
- Create a new Console Application in your IDE.
- In your `Main` method, define the essential variables for the game.
- **Action:**
    1.  Create a `string[]` to act as your `wordBank`. Add 5-10 words to it.
    2.  Create a `Random` object. Use it to select a single `secretWord` from the `wordBank`.
    3.  Initialize an `int guessesLeft = 10;`.
    4.  Create a `char[] displayWord` with the same length as `secretWord`, and use a `for` loop to fill it with `_` characters.
    5.  Create a `List<char>` named `guessedLetters` to keep track of all letters the player has guessed.

## 2. The Main Game Loop
- The core of your game will run inside a `while` loop.
- **Action:**
    1.  Create a `while` loop that continues as long as `guessesLeft > 0` and the word has not been fully guessed.
    2.  Inside the loop, you will perform all the steps below (display, input, processing).

## 3. Displaying the Game State
- Inside the loop, the first thing you should do is show the player the current status.
- **Action:**
    1.  Clear the console (`Console.Clear()`) for a clean interface (optional, but nice).
    2.  Print the `displayWord` array. You can use `string.Join(" ", displayWord)` to make it look nice, e.g., `_ a _ _ a _`.
    3.  Print the list of `guessedLetters` that were incorrect.
    4.  Print the number of `guessesLeft`.
    5.  Ask the player for their next guess.

## 4. Handling Player Input
- Get and validate the player's input.
- **Action:**
    1.  Use `Console.ReadLine()` to capture the input.
    2.  It's a good idea to convert the input to lowercase using `.ToLower()` to make comparisons easier.
    3.  Check if the input is `null` or empty. If so, inform the user and `continue` to the next loop iteration.

## 5. Processing the Guess (Core Logic)
- This is where you decide what to do with the player's input.
- **Action:**
    1.  **Check for duplicate guess:**
        *   If `input.Length == 1` (it's a letter), check if `guessedLetters.Contains(input[0])`.
        *   If it's a duplicate, inform the player and `continue` the loop. The assignment says this should not consume a guess.
    2.  **Handle a letter guess (`input.Length == 1`):**
        *   Add the letter to your `guessedLetters` list.
        *   Check if `secretWord.Contains(input)`.
        *   **If correct:** Use a `for` loop to go through `secretWord`. If `secretWord[i]` matches the guessed letter, update `displayWord[i]` with that letter.
        *   **If incorrect:** Decrement `guessesLeft`. Inform the player the letter was not in the word.
    3.  **Handle a whole word guess (`input.Length > 1`):**
        *   Compare the `input` directly with the `secretWord`.
        *   **If correct:** The player wins! You can set a `bool hasWon = true;` and `break` the loop.
        *   **If incorrect:** Decrement `guessesLeft`. Inform the player that the word was wrong.

## 6. Checking for a Win Condition
- Besides guessing the whole word, the player also wins if they reveal all the letters.
- **Action:**
    1.  After every correct letter guess, check if the `displayWord` no longer contains any `_`.
    2.  A simple way is to convert `displayWord` back to a string and compare it with `secretWord`.
    3.  If they match, set `bool hasWon = true;` to end the game.

## 7. Game Over
- After the `while` loop finishes, you need to tell the player whether they won or lost.
- **Action:**
    1.  Use an `if (hasWon)` statement.
    2.  If `true`, print a "Congratulations, you won!" message.
    3.  If `false`, print a "Game over! The correct word was: [secretWord]" message.

## 8. Final Steps
- **Requirement:** "Push your code to a GitHub repository and share your repository URL with your instructor before 15:00."
- **Action:**
    1.  Initialize a Git repository in your project folder.
    2.  Commit your working code.
    3.  Push the repository to GitHub and share the link.