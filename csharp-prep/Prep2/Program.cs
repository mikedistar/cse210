using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();

        float percentage = float.Parse(percent);
        string grade = "A";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage < 90 && percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage < 80 && percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage < 70 && percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"You got a {grade}.");
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time.");
        }
    }
}