//collections in c#
//generic stack follows LIFO (Last In First Out)
//generic stack provides type safety

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creating a generic stack
        Stack<int> stack = new Stack<int>();

        //pushing elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.WriteLine("Stack elements after pushing:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        //popping an element from the stack
        int poppedElement = stack.Pop();
        Console.WriteLine("\nPopped element: " + poppedElement);

        Console.WriteLine("\nStack elements after popping:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        //peeking the top element
        int topElement = stack.Peek();
        Console.WriteLine("\nTop element (peek): " + topElement);

        //count
        Console.WriteLine("\nTotal elements: " + stack.Count);
    }
}
