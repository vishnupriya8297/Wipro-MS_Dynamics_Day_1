//IN c# an array is a collection of elements of the same type stored in contiguous memory locations.
using System;
//declaring an array of integers with size 5
//Steps for creating Arrays in C#
	//Step 1: Declare the array of type int 
	//Step 2: Initialize the array with size 5
	//Step 3: Assign values to each index of the array
	//Step 4: Print the values of the array using a for loop
int[] numbers = new int[5];
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
//features of arrays in C#:
	//1. Fixed Size: Once an array is created, its size cannot be changed.( Collections like List<T> can be used for dynamic sizing)
	//2. Zero-Based Indexing: The first element of an array is accessed with index 0.
	//3. Homogeneous Elements: All elements in an array must be of the same data type.if they are not , type casting is required. collection 
	//4. Multi-Dimensional Arrays: C# supports multi-dimensional arrays (e.g., 2D arrays, 3D arrays).
	//5. Array Methods: C# provides various built-in methods for arrays, such as Sort(), Reverse(), and IndexOf().
	//6. Array Properties: Arrays have properties like Length, which returns the number of elements in the array.
	//7. Array Initialization: Arrays can be initialized at the time of declaration using curly braces {}.
//BUILT-IN METHODS
int[] arr = { 5, 2, 8, 1, 4 };
Array.Sort(arr);
Console.WriteLine("Sorted Array: ");
foreach (int num in arr)
{
    Console.WriteLine(num);
}
int[] a=new int[10];
for(int i=0;i<a.Length;i++)
{
    a[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Array Elements:");
for(int i=0;i<a.Length;i++)
{
    Console.WriteLine(a[i]);
}
//sort a[i]
Console.WriteLine("Sorted Array:");
Array.Sort(a);
for(int i=0;i<a.Length;i++)
{
    Console.WriteLine(a[i]);
}
//reverse a[i]
Console.WriteLine("Reversed Array:");
Array.Reverse(a);
for(int i=0;i<a.Length;i++)
{
    Console.WriteLine(a[i]);
}
//find index of an element
int index=Array.IndexOf(a,5);
Console.WriteLine("Index of 5:"+index);