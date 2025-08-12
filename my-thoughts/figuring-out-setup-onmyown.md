# ASSIGNMENT: Hangman

# = MY NOTES AND THOUGHTS

### 2. Game Rules to implement
-   The player has **10 guesses** to complete the word before losing the game.
     # - Create an array[10].
          # - Set up logic for deducting one value on init.
          # - I think a for-loop is the best alternative here.
     # - Each failure adds another "body part" to the hangman.
          - No need for a designed visual hangmang. We can simply state in text which part has been added, and what is currently on.
          - Logic for an array adding parts in this order:
               1. Body 
               2. Head
               3. Left arm
               4. Right arm
               5. Left leg
               6. Right leg
               7. Left hand
               8. Right hand
               9. Left foot
               10. Right foot
          - If fail, add (first) body from retrieve array into array[9] Hangman.
          - If word guess success: win the game.
          - If letter success: fill word array with guessed letter.
          -   If the player guesses the same letter twice, the program will not consume a guess.
               - New array for each letter in the alphabet?
               - Set up a for loop to check if the letter is already in the array.
               - If not, add it.
               - If yes, inform player the letter has already been used.
     # 3. Code Requirements
          - Use Random() to choose a random word from my pre-defined array of words.
          - Unrevealed letters must be represented by a lower dash (`_`).

### 4. Deadline
Finish the assignment by **Friday, August 15**. Push your code to a GitHub repository and share your repository URL with your instructor before **15:00**.