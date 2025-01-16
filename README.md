# C# DivideByZeroException Example

This repository demonstrates a common C# error: the `DivideByZeroException`. The `bug.cs` file contains code that attempts to divide by zero, resulting in this exception. The `bugSolution.cs` file shows how to handle this exception using a `try-catch` block.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the `MyMethod()` function.
4. Observe the `DivideByZeroException`.

## Solution

The solution is demonstrated in `bugSolution.cs`.  It uses a `try-catch` block to gracefully handle the potential exception, preventing the program from crashing.