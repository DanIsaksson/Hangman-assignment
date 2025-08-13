# WHAT I HAVE ALREADY LEARNED

### **Core Concepts**
*   **Variables:** Declaration, initialization, assignment, and scope (`int myNumber = 10;`).

### **Data Types**
*   **`string`**: For text.
*   **`int`**: For whole numbers.
*   **`bool`**: For true or false values.
*   **`double`**: For floating-point (decimal) numbers.
*   **`decimal`**: For high-precision decimal numbers, often used in financial applications.

### **Operators**
*   **Arithmetic:** `+`, `-`, `*`, `/`, `%` (modulus)
*   **Comparison:** `==`, `!=`, `<`, `>`, `<=`, `>=`
*   **Logical:** `&&` (AND), `||` (OR), `!` (NOT)
*   **Assignment:** `=`
*   **Increment/Decrement:** `++`, `--`
*   **Compound assignment:** `+=`, `-=`, `*=`, `/=`, `%=`
    * `x -= 1;` is equivalent to `x = x - 1;` and is preferred for brevity.
*   **Ternary:** `? :`

### **Control Flow**
*   **Conditional Statements:** Using `if`, `else if`, and `else`.
    ```csharp
    if (condition) { ... } else { ... }
    ```
*   **Loops:** Basic `for` loops.
    ```csharp
    for (int i = 0; i < 10; i++) { ... }
    ```

### **Console Interaction**
*   **Output:** `Console.WriteLine()` and `Console.Write()`.
*   **Input:** `Console.ReadLine()` to get user input as a string.
*   **Utility:** `Console.Clear()` to clear the console.

### **String Manipulation**
*   **Concatenation:** `string newString = "Hello" + " " + "World";`
*   **Properties & Methods:** `.Length`, `.EndsWith()`

### **Methods**
*   **Definition:** Creating methods with return types (`string`, `int`) or `void`.
    ```csharp
    void MyMethod(string parameter) { ... }
    ```*   **Returning Values:** Using the `return` keyword.
*   **Calling Methods:** `MyMethod("some value");`
*   **Method Overloading:** The concept of having multiple methods with the same name but different parameters.

### **Type Conversion & Parsing**
*   **Parsing Strings to Number:**
    *   `int.Parse()`
    *   `double.Parse()`
    *   `decimal.Parse()`
*   **Safe Parsing:** Using `int.TryParse()` to avoid exceptions on invalid input.
*   **Converting to String:** Using `.ToString()`.
*   **Exception Handling:** Awareness of `System.FormatException` when parsing fails.

### Input Validation and Parsing
- Using TryParse avoids exceptions and lets you branch on valid vs. invalid input.
    - Example pattern: if (char.TryParse(Console.ReadLine(), out char c)) { /* use c */ } else { /* handle invalid */ }
- Important: Handle the quit option (e.g., 'Q') inside the success branch of TryParse; otherwise, you may read invalid data or never reach the condition.
- Prefer normalizing case with ToLowerInvariant() or ToUpperInvariant() before comparisons to avoid case mismatches.

### char vs string
- Single characters use single quotes: 'a'. Strings use double quotes: "a".
- Comparing a char to a string causes type errors; ensure both sides are the same type.

### Loop Structure for Guessing
- One letter per turn: read the letter ONCE per turn, then iterate through the secret word to reveal all matching positions.
- Do not call input-reading methods (like GetValidLetter) inside a loop that iterates over word positions; doing so asks the user multiple times per turn.

### Variable Scope and Access
- Accessing a field from another class requires the correct qualifier (e.g., Program.secretWord if it is a static field of Program).
- Decide between static and instance members:
    - Static: simple to access globally but couples code; use sparingly for shared, immutable configuration or singletons.
    - Instance: promotes encapsulation; pass instances where needed or pass data as parameters.
- Alternative to statics: create a GameState class that holds the current word, guessesLeft, remainingLetters, and wordState; pass it to functions that need it.

### Win Conditions
- Two common checks:
    - All positions filled (no '_' left) or remainingLetters == 0.
    - Whole-word guess equals secretWord.
- Keep remainingLetters in sync with wordState; decrement only when you newly reveal a position (avoid double-decrement for repeated guesses of the same letter).