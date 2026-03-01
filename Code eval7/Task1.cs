using System;

// Define delegate type
// Complete Step 1:............
public delegate int Operation(int a, int b);

class Program
{
    // Implement delegate methods
    // Complete Step 2:............
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
            // throw new DivideByZeroException("Cannot divide by zero.");
            return 0;
        return a / b;
    }

    public static int PerformOperation(int x, int y, Operation op)
    {
        return op(x, y);
    }

    // Implement callback mechanism
    // Complete Step 3:............

    static void Main(string[] args)
    {
        // Input handling
        // Complete Step 4:............
        try
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
            string choice = Console.ReadLine().Trim().ToLower();

            Operation operation = null;

            switch (choice)
            {
                case "add":
                    operation = Add;
                    break;
                case "subtract":
                    operation = Subtract;
                    break;
                case "multiply":
                    operation = Multiply;
                    break;
                case "divide":
                    operation = Divide;
                    break;
                default:
                    // Console.WriteLine("Invalid operation.");
                    return;
            }

            int result = PerformOperation(num1, num2, operation);
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
            // Console.WriteLine("Invalid input. Please enter integers only.");
        }
        catch (DivideByZeroException ex)
        {
            // Console.WriteLine(ex.Message);
        }
    }
}