using System;

abstract class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary { get; set; }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class PartTimeEmployee : Employee
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

class Experiment4
{
    static void Main()
    {
        FullTimeEmployee fte = new FullTimeEmployee { Name = "Alice", ID = 101, MonthlySalary = 50000 };
        PartTimeEmployee pte = new PartTimeEmployee { Name = "Bob", ID = 102, HourlyRate = 300, HoursWorked = 40 };

        Console.WriteLine($"{fte.Name}'s Salary: {fte.CalculateSalary()}");
        Console.WriteLine($"{pte.Name}'s Salary: {pte.CalculateSalary()}");
    }
}
