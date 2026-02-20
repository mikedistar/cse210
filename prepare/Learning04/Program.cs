using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Assignment firstAssignment = new Assignment("Samuel Bennet", "Multiplication");

        MathAssignment mathAssignment = new MathAssignment("Section 7.3", "Problems 8-19", "Roberto Rodriguez", "Fractions");
        
        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II", "Mary Walters", "European History");

        Console.WriteLine(firstAssignment.GetSummary());

        Console.WriteLine(mathAssignment.GetSummary());

        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine(writingAssignment.GetSummary());

        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}