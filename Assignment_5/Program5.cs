using System;

// Custom exception class
public class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message)
    {
    }
}

// Student class
public class Student
{
    public string Name { get; set; }
    private int marks;

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new InvalidMarksException("Marks must be between 0 and 100.");
            }
            marks = value;
        }
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        Student s1 = new Student();

        try
        {
            Console.Write("Enter student name: ");
            s1.Name = Console.ReadLine();

            Console.Write("Enter marks (0–100): ");
            s1.Marks = Convert.ToInt32(Console.ReadLine());

            s1.Display();
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer for marks.");
        }
        finally
        {
            Console.WriteLine("Validation process completed.");
        }
    }
}
