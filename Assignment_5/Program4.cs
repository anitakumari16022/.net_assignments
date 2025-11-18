using System;


public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

public class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Withdrawal amount exceeds available balance!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal successful! Remaining Balance: {Balance}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Bhawana", 5000);

        Console.Write("Enter withdrawal amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        try
        {
            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}
