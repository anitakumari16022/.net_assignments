using System;

class Student
{
    public string Name;
    public int RollNo;
    public double Marks;

    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        Marks = 0;
    }

    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
        Marks = 0;
    }

    public Student(string name, int rollNo, double marks)
    {
        Name = name;
        RollNo = rollNo;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, RollNo: {RollNo}, Marks: {Marks}");
    }
}

class Experiment5
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student("Alice", 1);
        Student s3 = new Student("Bob", 2, 89.5);

        s1.Display();
        s2.Display();
        s3.Display();
    }
}
