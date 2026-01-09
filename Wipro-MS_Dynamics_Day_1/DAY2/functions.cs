using System;

class ResultCalculator
{
    // Function to calculate total marks
    static int CalculateTotal(int marks1, int marks2, int marks3)
    {
        int total = marks1 + marks2 + marks3;
        return total;
    }

    // Function to calculate average
    static double CalculateAverage(int totalMarks)
    {
        double average = totalMarks / 3.0;
        return average;
    }

    // Function to check result
    static string CheckResult(double average)
    {
        if (average >= 50)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

    // Main function
    static void Main()
    {
        int m1 = int.Parse(Console.ReadLine());
        int m2 = int.Parse(Console.ReadLine());
        int m3 = int.Parse(Console.ReadLine());

        int totalMarks = CalculateTotal(m1, m2, m3);
        Console.WriteLine("Total Marks: " + totalMarks);

        double average = CalculateAverage(totalMarks);
        Console.WriteLine("Average Marks: " + average);

        string result = CheckResult(average);
        Console.WriteLine("Result: " + result);
    }
}
//creating another example for functions is car parking
