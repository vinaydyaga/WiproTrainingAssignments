using System;

class Book
{
    // Define properties
    public string Title;
    public string Author;
    public int Year;
    // Complete Step 1:............

    // Define constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    // Complete Step 2:............
}

class Program
{
    static void Main(string[] args)
    {
        string title;
        string author;
        int year;
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        title=Console.ReadLine();
        // Complete Step 3:............

        Console.WriteLine("Enter book's author:");
        author=Console.ReadLine();
        // Complete Step 4:............

        Console.WriteLine("Enter book's year:");
        year=Convert.ToInt32(Console.ReadLine());
        // Complete Step 5:............

        // Create an instance of the Book class
        Book b1=new Book(title,author,year);


        // Complete Step 6:............

        // Print book details
        Console.WriteLine("Book Title: "+b1.Title);
        Console.WriteLine("Book Author: "+b1.Author);
        Console.WriteLine("Book Year: "+b1.Year);
        // Complete Step 7:............
    }
}