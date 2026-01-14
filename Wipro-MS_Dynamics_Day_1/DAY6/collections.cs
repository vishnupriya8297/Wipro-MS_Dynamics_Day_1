//collections in c#
//stack is a collection that follows the LIFO(Last In First Out) principle
//stack is used when we need to access data in reverse order
//creating non-generic stack 
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        //creating a stack
        Stack stack = new Stack();

        //pushing elements onto the stack
        stack.Push(10);
        stack.Push("hi");
        stack.Push(false);
        stack.Push(40);

        Console.WriteLine("Stack elements after pushing:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        //popping an element from the stack
        var poppedElement = stack.Pop();
        Console.WriteLine("\nPopped element: " + poppedElement);

        Console.WriteLine("\nStack elements after popping:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        //peeking at the top element of the stack
        var topElement = stack.Peek();
        Console.WriteLine("\nTop element (peek): " + topElement);
    }
}
//in-built methods in stack class:
//Push(): Adds an item to the top of the stack.
//Pop(): Removes and returns the item at the top of the stack.
//Peek(): Returns the item at the top of the stack without removing it.
//Count: Gets the number of items in the stack.
//Contains(): Determines whether an item is in the stack.
//Clear(): Removes all items from the stack.
//ToArray(): Copies the stack to a new array.
//TrimExcess(): Sets the capacity to the actual number of elements in the stack, if that number is less than 90 percent of current capacity.
//These methods help in managing and manipulating the stack data structure effectively.
//creating a generic stack




