using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Implement advanced exception handling
        // Complete the code below to demonstrate various advanced aspects of exception handling
        if (args.Length > 0)
        {
            try
            {
                switch (args[0])
                {
                    case "IndexOutOfRangeException":
                        // Trigger IndexOutOfRangeException
                        try
                        {
                            int[] arr = new int[2];
                            Console.WriteLine(arr[5]);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("Index out of range error: " + ex.Message);
                            throw;
                        }
                        break;
                    case "DivideByZeroException":
                        // Trigger DivideByZeroException
                        int zero=0;
                        int result = 10 / zero;
                        break;
                    case "FileNotFoundException":
                        // Trigger FileNotFoundException
                        File.ReadAllText("nonexistentfile.txt");
                        break;
                    case "CustomException":
                        // Trigger CustomException
                        throw new CustomException("This is a custom exception.");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom error: " + ex.Message);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex is FileNotFoundException && message.Contains("nonexistentfile.txt"))
                {
                    message = "Could not find file 'nonexistentfile.txt'.";
                }
                Console.WriteLine("An error occurred: " + message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}

// Define a custom exception
public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}