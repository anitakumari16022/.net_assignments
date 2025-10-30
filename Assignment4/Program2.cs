using System;

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 5 && value <= 25)
                age = value;
            else
            {
                Console.WriteLine($"Invalid age {value}, defaulting to 18.");
                age = 18;
            }
        }
    }

    static void Main()
    {
        Student s1 = new Student();
        s1.Age = 4;   
        Console.WriteLine("Age: " + s1.Age);

        Student s2 = new Student();
        s2.Age = 20; 
        Console.WriteLine("Age: " + s2.Age);

        Student s3 = new Student();
        s3.Age = 30;  
        Console.WriteLine("Age: " + s3.Age);
    }
}
