using System;

class BankAccount
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Withdraw(500);
    }
}
