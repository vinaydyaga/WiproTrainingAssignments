using System;

class CustomCollection
{
    private string[] elements = new string[10];
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return elements[index];
        }
        set
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            elements[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomCollection collection = new CustomCollection();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter index to set:");
            int setIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value to set:");
            string value = Console.ReadLine();

            collection[setIndex] = value;
            Console.WriteLine("Enter index to get:");
            int getIndex = Convert.ToInt32(Console.ReadLine());

            string result = collection[getIndex];

            Console.WriteLine("Retrieved value: " + result);
        }
    }
}