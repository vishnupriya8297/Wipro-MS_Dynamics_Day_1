//static keyword in C# is used to declare members that belong to the type itself rather than to a specific object.
using System;
public static class calulator
{
    public static int add(int a,int b)
    {
        return a + b;
    }
    public static int sub(int a,int b)
    {
        return a - b;
    }
    public static int mul(int a,int b)
    {
        return a * b;
    }
}
//creating main class
//static class cannot be instantiated
//static class can only contain static members
//static class is sealed and cannot be inherited
//static methods are inherited
//static methods are overriden? No!why? because static methods are not associated with any object
public class Program
{
    public static void Main(string[] args)
    {
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt16(Console.ReadLine());
        // here we are calling static method using class name without creating object
        Console.WriteLine(calulator.add(a,b));
        Console.WriteLine(calulator.sub(a,b));
        Console.WriteLine(calulator.mul(a,b));
        
    }
}