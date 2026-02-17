using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............

    private int number = 5;

    public int Number
    {
        get { return number; }
    }

    // Private property
    private string PrivateProperty
    {
        get { return "Private Value"; }
    }

    public void ShowPrivateValue()
    {
        Console.WriteLine(PrivateProperty);
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............

    public static int value;

    static StaticDemo()
    {
        value = 10;
        Console.WriteLine("Static Constructor");
    }

    public static void ShowMessage()
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
        PropertyDemo obj = new PropertyDemo();
        Console.WriteLine(obj.Number);
        obj.ShowPrivateValue();
        Console.WriteLine(StaticDemo.value);
        StaticDemo.ShowMessage();
        Console.WriteLine(MathHelper.Add(10, 5));
        Console.WriteLine(MathHelper.Subtract(10, 5));
    }
}