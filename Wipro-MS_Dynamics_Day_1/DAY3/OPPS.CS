using System;
using System.Collections.Generic;

// =======================
// ABSTRACT ACCOUNT CLASS
// (Abstraction + Encapsulation)
// =======================
public abstract class Account
{
    private int accountNumber;
    private string holderName;
    protected double balance;

    public void SetDetails(int accNo, string name, double bal)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    // abstract method
    public abstract void Withdraw(double amount);

    public void DisplayDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("---------------------");
    }
}

// =======================
// SAVINGS ACCOUNT
// (Inheritance + Polymorphism)
// =======================
public class SavingsAccount : Account
{
    public override void Withdraw(double amount)
    {
        if (balance - amount >= 1000)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Minimum balance of 1000 required.");
        }
    }
}

// =======================
// CURRENT ACCOUNT
// (Inheritance + Polymorphism)
// =======================
public class CurrentAccount : Account
{
    public override void Withdraw(double amount)
    {
        balance -= amount; // overdraft allowed
    }
}

// =======================
// CUSTOMER CLASS
// (Encapsulation)
// =======================
public class Customer
{
    private string customerId;
    private string customerName;
    private long phoneNumber;
    private string address;

    public void SetCustomer(string id, string name, long phone, string addr)
    {
        customerId = id;
        customerName = name;
        phoneNumber = phone;
        address = addr;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine("Customer ID: " + customerId);
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Address: " + address);
    }
}

// =======================
// BANK CLASS
// (Object Interaction)
// =======================
public class Bank
{
    private List<Account> accounts = new List<Account>();

    public void CreateAccount(Account acc)
    {
        accounts.Add(acc);
    }

    public void Deposit(int accNo, double amount)
    {
        Account acc = accounts.Find(a => a.GetAccountNumber() == accNo);
        if (acc != null)
            acc.Deposit(amount);
    }

    public void Withdraw(int accNo, double amount)
    {
        Account acc = accounts.Find(a => a.GetAccountNumber() == accNo);
        if (acc != null)
            acc.Withdraw(amount);
    }

    public void ShowAccount(int accNo)
    {
        Account acc = accounts.Find(a => a.GetAccountNumber() == accNo);
        if (acc != null)
            acc.DisplayDetails();
    }
}

// =======================
// MAIN CLASS
// =======================
class MainClass
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        // Polymorphism
        Account acc1 = new SavingsAccount();
        acc1.SetDetails(101, "vishnu", 5000);

        Account acc2 = new CurrentAccount();
        acc2.SetDetails(102, "priya", 3000);

        bank.CreateAccount(acc1);
        bank.CreateAccount(acc2);

        bank.Deposit(101, 2000);
        bank.Withdraw(101, 5500);   // savings rule

        bank.Deposit(102, 1000);
        bank.Withdraw(102, 5000);   // overdraft allowed

        bank.ShowAccount(101);
        bank.ShowAccount(102);

        Console.WriteLine("OOPS Concepts Implemented Successfully");
    }
}
