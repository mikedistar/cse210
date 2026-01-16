using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int PromtUserBirthYear()
        {
            Console.Write("Which year were you born? ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }

        static int SquareNumber(int number)
        {
            int squared_number = number * number;
            return squared_number;
        }

        static int DisplayResult(string name, int squared_number, int year)
        {
            int current_year = 2026;
            Console.WriteLine($"{name}, the square of your number is {squared_number}");
            Console.WriteLine($"{name}, you will turn {current_year - year}");

            return 3;
        }

        int year;
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared_number = SquareNumber(number);
        year = PromtUserBirthYear();
        DisplayResult(name, squared_number, year);
        

    }
}