//if statement in C# is used to execute a block of code based on a specified condition.
// If statement example
int q=10;
if(q%2==0)
{
    Console.WriteLine("Even Number");
}
//if-else statement in C# is used to execute one block of code if a condition is true, and another block if the condition is false.
// If-Else statement example
int p=7;
if(p>0)
{
    Console.WriteLine("Positive Number");
}
else
{
    Console.WriteLine("Negative Number");
}
//if-else if-else ladder in C# is used to evaluate multiple conditions sequentially.
// If-Else If-Else Ladder example
int marks=int.Parse(Console.ReadLine());
if(marks>=90)
{
    Console.WriteLine("Grade A");
}
else if(marks>=75)
{
    Console.WriteLine("Grade B");
}
else if(marks>=50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}

//switch statement in C# is used to execute one block of code among multiple options based on the value of a variable or expression.
// Switch statement example
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("One");
        break;

    case 2:
        Console.WriteLine("Two");
        break;

    case 3:
        Console.WriteLine("Three");
        break;

    default:
        Console.WriteLine("Invalid number");
        break;
}
