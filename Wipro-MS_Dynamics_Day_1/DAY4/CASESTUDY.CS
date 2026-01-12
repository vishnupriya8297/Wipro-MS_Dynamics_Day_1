using System;

class PlatformSettings
{
    //static variables 
    private static string platformName = "Online Learning Platform";
    private static int totalRegisteredUsers = 0;
    private static int maxLoginAttempts = 5;
    private static double globalDiscountRate = 10.0;

    //static methods to access those static variables
    public static string PlatformName
    {
        get { return platformName; }
    }
    public static int TotalRegisteredUsers
    {
        get { return totalRegisteredUsers; }
    }
    
    public static int MaxLoginAttempts
    {
        get { return maxLoginAttempts; }
        set
        {
            if (value > 0)
                maxLoginAttempts = value;
        }
    }
    //this static method is used to set global discount rate for all users

    public static double GlobalDiscountRate
    {
        get { return globalDiscountRate; }
        set
        {
            if (value >= 0 && value <= 100)
                globalDiscountRate = value;
        }
    }

   
    public static void RegisterUserdetails()
    {
        totalRegisteredUsers++; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Registering users
        PlatformSettings.RegisterUserdetails();
        PlatformSettings.RegisterUserdetails();

        // Accessing static properties
        Console.WriteLine("Platform Name: " + PlatformSettings.PlatformName);
        Console.WriteLine("Total Registered Users: " + PlatformSettings.TotalRegisteredUsers);
        Console.WriteLine("Max Login Attempts: " + PlatformSettings.MaxLoginAttempts);
        Console.WriteLine("Global Discount Rate: " + PlatformSettings.GlobalDiscountRate + "%");

        // Updating global settings
        PlatformSettings.MaxLoginAttempts = 3;
        PlatformSettings.GlobalDiscountRate = 15.0;

        Console.WriteLine("\nAfter Updating Settings:");
        Console.WriteLine("Max Login Attempts: " + PlatformSettings.MaxLoginAttempts);
        Console.WriteLine("Global Discount Rate: " + PlatformSettings.GlobalDiscountRate + "%");
    }
}
