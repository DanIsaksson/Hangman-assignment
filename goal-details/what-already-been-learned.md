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
*   **Increment:** `++`
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