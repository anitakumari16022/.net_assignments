using System;

class Employee
{
    private double basicSalary;

    public double BasicSalary
    {
        set { basicSalary = value; }
    }

    public double TotalSalary
    {
        get { return basicSalary + (0.2 * basicSalary); }
    }

    static void Main()
    {
        Employee e1 = new Employee();
        e1.BasicSalary = 30000;
        Console.WriteLine("Total Salary: " + e1.TotalSalary);
    }
}
