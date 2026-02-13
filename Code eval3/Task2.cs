using System;

class Book
{
    // Define properties
    // Complete Step 1:............
    public string  Title{get; set; }
    public string Author{get; set; }
    public int Year {get; set; }

    // Define constructor
    // Complete Step 2:............
    public Book(string title, string author, int year)
    {
        Title=title;
        Author=author;
        Year=year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        string title=Console.ReadLine();
        // Complete Step 3:............

        Console.WriteLine("Enter book's author:");
        string author=Console.ReadLine();
        // Complete Step 4:............

        Console.WriteLine("Enter book's year:");
        int year=Convert.ToInt32(Console.ReadLine());
        // Complete Step 5:............

        // Create an instance of the Book class
        Book myBook=new Book(title, author, year);
        // Complete Step 6:............

        // Print book details
        Console.WriteLine("Book Title: "+myBook.Title);
        Console.WriteLine("Book Author: "+myBook.Author);
        Console.WriteLine("Book Year: "+myBook.Year);
        // Complete Step 7:............
    }
}