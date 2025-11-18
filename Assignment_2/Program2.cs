using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

class Truck : Vehicle
{
    public Truck(string make, string model, int year) : base(make, model, year) { }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Make}, {Model}, {Year}");
    }
}

class Bus : Vehicle
{
    public Bus(string make, string model, int year) : base(make, model, year) { }

    public void DisplayDetails()
    {
        Console.WriteLine($"Bus: {Make}, {Model}, {Year}");
    }
}

class Experiment2
{
    static void Main()
    {
        Truck t1 = new Truck("Tata", "Hauler", 2022);
        Bus b1 = new Bus("Volvo", "XC", 2023);
        t1.DisplayDetails();
        b1.DisplayDetails();
    }
}
