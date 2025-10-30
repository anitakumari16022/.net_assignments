using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
}

class Experiment3
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Add int: " + calc.Add(5, 10));
        Console.WriteLine("Add float: " + calc.Add(3.5f, 4.2f));
        Console.WriteLine("Add double: " + calc.Add(2.3, 3.1, 4.6));
    }
}
