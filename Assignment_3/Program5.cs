using System;

class Shape
{
    protected double Area { get; set; }

    public virtual void CalculateArea()
    {
        Area = 0;
    }

    public void DisplayArea()
    {
        Console.WriteLine("Area: " + Area);
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override void CalculateArea()
    {
        Area = Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override void CalculateArea()
    {
        Area = Length * Width;
    }
}

class ShapeExample
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        c.CalculateArea();
        Console.Write("Circle ");
        c.DisplayArea();

        Rectangle r = new Rectangle { Length = 4, Width = 6 };
        r.CalculateArea();
        Console.Write("Rectangle ");
        r.DisplayArea();
    }
}
