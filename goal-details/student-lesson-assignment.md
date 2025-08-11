# ASSIGNMENT: Hangman

### 1. Hangman Game
Your assignment is to create a console game called Hangman. Hangman is a classic word-guessing game for two or more players ([Wikipedia](https://en.wikipedia.org/wiki/Hangman_(game))). In this version, one player (the application) thinks of a word, and the other player (the user) tries to guess it by suggesting letters. The word to guess is represented by a row of dashes, where each dash represents a letter in the word.

### 2. Game Rules to implement
-   The player has **10 guesses** to complete the word before losing the game.
-   The player can make two types of guesses:
    -   **Guess for a specific letter:** If the player guesses a letter that occurs in the word, the program should update the displayed word by inserting the letter in the correct position(s).
    -   **Guess for the whole word:** The player can type in a full word they think is the secret word. If the guess is correct, the player wins the game, and the whole word is revealed. If the word is incorrect, nothing is revealed, and it counts as a wrong guess.
-   If the player guesses the same letter twice, the program will not consume a guess.

### 3. Code Requirements
-   The secret word should be **randomly chosen** from a `string` array you define.
-   The program must keep track of the **incorrect letters** the player has guessed and present them to the player after each guess.
-   The correctly guessed letters should be stored in a `char` array (or similar structure). Unrevealed letters must be represented by a lower dash (`_`).

### 4. Deadline
Finish the assignment by **Friday, August 15**. Push your code to a GitHub repository and share your repository URL with your instructor before **15:00**.