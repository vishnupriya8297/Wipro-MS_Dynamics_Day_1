//access modifiers in C#
//access modifiers are keywords used to specify the declared accessibility of a member or a type.
//access modifiers are used to control the visibility of class members and types to other parts of the program.
//public, private, protected, internal, protected internal, and private protected are the six access modifiers in C#.
//public: The member or type is accessible from any other code in the same assembly or another assembly that references it.
//private: The member is accessible only within the body of the class or struct in which it is declared.
//protected: The member is accessible within its class and by derived class instances.  
//internal: The member or type is accessible only within files in the same assembly.
//protected internal: The member is accessible within its assembly or from derived classes.
//private protected: The member is accessible only within its containing class or types derived from the containing class within the same assembly.
//example of access modifiers is bank account management system
using System;
using System;

namespace BankSystem
{
    // Exposed to other assemblies
    public class BankAccount
    {
        // Secures sensitive data
        private decimal balance;

        // Controlled inheritance
        protected string AccountType;

        // Restricted within assembly
        internal int AccountId;

        public BankAccount(int id, decimal initialBalance)
        {
            AccountId = id;
            balance = initialBalance;
            AccountType = "Generic Account";
        }

        // Exposed functionality
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }
    }

    // Derived class using protected members
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int id, decimal balance)
            : base(id, balance)
        {
            AccountType = "Savings Account";
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(101, 5000);
            account.Deposit(2000);
            account.ShowBalance();

            SavingsAccount savings = new SavingsAccount(102, 8000);
            savings.ShowBalance();

            Console.ReadLine();
        }
    }
}
