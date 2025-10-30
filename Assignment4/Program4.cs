using System;

class Product
{
    public double Price { get; set; }
    public double Discount { get; set; }

    public double CalculateFinalPrice()
    {
        return Price - (Price * Discount / 100);
    }

    static void Main()
    {
        Product p = new Product { Price = 2000, Discount = 10 };
        Console.WriteLine("Final Price: " + p.CalculateFinalPrice());
    }
}
