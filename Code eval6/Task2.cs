using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............
    public int Number { get; set; }

    private string PrivateMessage { get; set; }

    public string ReadOnlyMessage
    {
        get { return PrivateMessage; }
    }

    public PropertyDemo(int number)
    {
        Number = number;
        PrivateMessage = "Private Value";
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............
    public static int StaticValue;

    static StaticDemo()
    {
        StaticValue = 10;
    }

    public static void DisplayMessage()
    {
        Console.WriteLine("Static Method");
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Define static methods
    // Complete Step 3:............
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main()
    {
        // Demonstrate usage
        // Complete Step 4:............
        PropertyDemo obj = new PropertyDemo(5);
        Console.WriteLine(obj.Number);
        Console.WriteLine(obj.ReadOnlyMessage);
        Console.WriteLine(StaticDemo.StaticValue);
        StaticDemo.DisplayMessage();
        Console.WriteLine(MathHelper.Add(10, 5));
        Console.WriteLine(MathHelper.Subtract(10, 5));
    }
}