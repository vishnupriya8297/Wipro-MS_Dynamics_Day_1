// Voting eligibility program
//read age from user and check if eligible to vote
Console.WriteLine("Please enter your age:");
// Read input from user
string ageInput = Console.ReadLine();
// Convert input to integer
int age;
// Validate and check eligibility
bool isValidAge = int.TryParse(ageInput, out age);
// Check if age is valid and determine voting eligibility
if(isValidAge)
{
    if(age >= 18)
    {
        Console.WriteLine("You are eligible to vote.");
    }
    else
    {
        Console.WriteLine("You are not eligible to vote.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid age.");
}
