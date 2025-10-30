using System;

class Car
{
    private int speed;
    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > 180)
            {
                Console.WriteLine("Speed exceeds limit! Resetting to 180.");
                speed = 180;
            }
            else
                speed = value;
        }
    }

    static void Main()
    {
        Car c = new Car();
        c.Speed = 150;
        Console.WriteLine("Speed: " + c.Speed);

        c.Speed = 200;
        Console.WriteLine("Final Speed: " + c.Speed);
    }
}
