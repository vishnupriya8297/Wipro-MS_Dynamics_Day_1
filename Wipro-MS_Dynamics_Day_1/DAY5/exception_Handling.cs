using System;

// Custom Exception
public class DailyLimitExceededException : Exception
{
    public DailyLimitExceededException()
        : base("Daily transaction limit exceeded.")
    {
    }

    public DailyLimitExceededException(string message)
        : base(message)
    {
    }
}

// Business Logic Class
class BankAccount
{
    private decimal dailyLimit = 1000m;
    private decimal totalTransactionsToday = 0m;

    public void MakeTransaction(decimal amount)
    {
        if (totalTransactionsToday + amount > dailyLimit)
        {
            throw new DailyLimitExceededException();
        }

        totalTransactionsToday += amount;
        Console.WriteLine($"Transaction of {amount} completed successfully.");
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        try
        {
            account.MakeTransaction(300);
            account.MakeTransaction(500);
            account.MakeTransaction(20000); // This will throw exception
        }
        catch (DailyLimitExceededException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction process finished.");
        }
    }
}
