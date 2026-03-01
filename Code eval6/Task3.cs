using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Implement exception handling
        // Complete the code below to demonstrate various aspects of exception handling
        try
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "IndexOutOfRangeException":
                        // Trigger IndexOutOfRangeException
                        int[] numbers = { 1, 2, 3 };
                        Console.WriteLine(numbers[5]);
                        break;
                    case "DivideByZeroException":
                        // Trigger DivideByZeroException
                        int a = 10;
                        int b = 0;
                        Console.WriteLine(a / b);
                        break;
                    case "FileNotFoundException":
                        // Trigger FileNotFoundException
                        File.ReadAllText("dummy.txt");
                        break;
                }
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range error: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero error: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General error: " + ex.Message);
        }
    }
}