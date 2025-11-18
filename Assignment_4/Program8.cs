using System;

delegate void BillingOperation(double amount);

class Billing
{
    static double price;
    static double discounted;
    static double taxed;
    static double finalAmount;

    static void ShowTotal(double amt)
    {
        price = amt;
        Console.WriteLine($"Original Price: ₹{price}");
    }

    static void ApplyDiscount(double amt)
    {
        discounted = price - (price * 0.10);
        Console.WriteLine($"After 10% Discount: ₹{discounted}");
    }

    static void AddTax(double amt)
    {
        taxed = discounted + (discounted * 0.18);
        Console.WriteLine($"After 18% GST: ₹{taxed}");
    }

    static void FinalBill(double amt)
    {
        finalAmount = taxed;
        Console.WriteLine($"Final Payable Amount: ₹{finalAmount}");
    }

    static void Main()
    {
        BillingOperation bill = ShowTotal;
        bill += ApplyDiscount;
        bill += AddTax;
        bill += FinalBill;

        bill(5000);
    }
}
