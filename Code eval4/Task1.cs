using System;

class Vehicle
{
    // Define properties
    public string Make{get; set;}
    public string Model{get; set;}
    public int Year{get; set;}

    public Vehicle(string make, string model, int year){
        Make=make;
        Model=model;
        Year=year;
    }
    public virtual void GetInfo(){
        Console.WriteLine(Year +" "+ Make +" "+ Model);
        
    }
    // Complete Step 1:............

    // Define constructor
    // Complete Step 2:............

    // Define virtual method
    // Complete Step 3:............
}

class Car : Vehicle
{
    public Car(string make,string model, int year) : base(make,model,year)
    {

    }
    public override void GetInfo()
    {
        // Console.WriteLine("car Details :");
        Console.Write("Car: ");
        base.GetInfo();
    }
    // Override GetInfo method
    // Complete Step 4:............
}

class Motorcycle : Vehicle
{
    public Motorcycle(string make,string model, int year) : base(make,model,year)
    {

    }
    public override void GetInfo()
    {
        // Console.WriteLine("MoterCycle Details :");
        Console.Write("Motorcycle: ");
        base.GetInfo();
    }
    // Override GetInfo method
    // Complete Step 5:............
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter vehicle details for Car
        Console.WriteLine("Enter car make:");
        string carMake=Console.ReadLine();
        // Complete Step 6:............

        Console.WriteLine("Enter car model:");
        string carModel=Console.ReadLine();
        // Complete Step 7:............

        Console.WriteLine("Enter car year:");
        int carYear=Convert.ToInt32(Console.ReadLine());
        // Complete Step 8:............

        // Prompt the user to enter vehicle details for Motorcycle
        Console.WriteLine("Enter motorcycle make:");
        string bikeMake=Console.ReadLine();
        // Complete Step 9:............

        Console.WriteLine("Enter motorcycle model:");
        string bikeModel=Console.ReadLine();
        // Complete Step 10:............

        Console.WriteLine("Enter motorcycle year:");
        int bikeYear=Convert.ToInt32(Console.ReadLine());
        // Complete Step 11:............

        // Create instances of Car and Motorcycle
        Car car=new Car(carMake,carModel,carYear);
        Motorcycle motercycle =new Motorcycle(bikeMake,bikeModel,bikeYear);
        // Complete Step 12:............

        // Display vehicle information
        car.GetInfo();
        motercycle.GetInfo();
        

        // Complete Step 13:............
    }
}