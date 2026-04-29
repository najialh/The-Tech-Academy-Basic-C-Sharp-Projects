using System;

// Create a class named MathOperations
class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer
        int result = firstNumber * 2;

        // Display the result of the math operation
        Console.WriteLine("First number multiplied by 2 = " + result);

        // Display the second integer to the screen
        Console.WriteLine("Second number = " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the class
        MathOperations math = new MathOperations();

        // Call the method using regular parameters
        math.DoMath(5, 10);

        // Call the method using named parameters
        math.DoMath(firstNumber: 7, secondNumber: 20);

        // Pause the console so results stay visible
        Console.ReadLine();
    }
}