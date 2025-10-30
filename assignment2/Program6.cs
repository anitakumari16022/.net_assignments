using System;

class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }

    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                Console.WriteLine("Price cannot be negative!");
        }
    }

    public int Quantity { get; set; }

    public void DisplayProduct()
    {
        Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
    }
}

class Experiment6
{
    static void Main()
    {
        Product p1 = new Product { ProductID = 1, ProductName = "Laptop", Price = 50000, Quantity = 10 };
        p1.DisplayProduct();

        Product p2 = new Product { ProductID = 2, ProductName = "Mouse", Price = -100, Quantity = 5 };
        p2.DisplayProduct();
    }
}
