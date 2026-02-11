using System;

class Program
{
    static void Main(string[] args)
    {
        int a,b,sum;
        Console.WriteLine("Enter the first number:");
        a=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second number:");
        b=Convert.ToInt32(Console.ReadLine());
        
        sum=a+b;
        Console.WriteLine("The sum is: "+sum);
    }
}