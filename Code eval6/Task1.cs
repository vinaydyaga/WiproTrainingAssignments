using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............
    public int Number { get; set; } = 5;

    private string message = "Private Value";

    public void ShowMessage()
    {
        Console.WriteLine(message);
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............
    public static int StaticNumber;

    static StaticDemo()
    {
        StaticNumber = 10;
        Console.WriteLine("Static Constructor");
    }

    public static void ShowStaticMethod()
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
}

public class Program
{
    public static void Main()
    {
        // Demonstrate usage
        // Complete Step 4:............
        PropertyDemo obj = new PropertyDemo();
        Console.WriteLine(obj.Number);
        obj.ShowMessage();
        Console.WriteLine(StaticDemo.StaticNumber);
        StaticDemo.ShowStaticMethod();
        Console.WriteLine(MathHelper.Add(10, 5));
        Console.WriteLine(obj.Number); 
    }
}