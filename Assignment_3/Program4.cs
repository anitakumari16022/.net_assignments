using System;

class Person
{
    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException("Age must be between 0 and 100.");
            age = value;
        }
    }
}

class Employee : Person
{
    private double salary;

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
    }
}

class ValidationExample
{
    static void Main()
    {
        try
        {
            Employee emp1 = new Employee();
            emp1.Name = "Alice";
            emp1.Age = -5; 
            emp1.Salary = 50000;
            emp1.DisplayDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }

        try
        {
            Employee emp2 = new Employee();
            emp2.Name = "Bob";
            emp2.Age = 30;
            emp2.Salary = -1000; 
            emp2.DisplayDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }

            Employee emp3 = new Employee { Name = "Charlie", Age = 25, Salary = 60000 };
        emp3.DisplayDetails();
    }
}
