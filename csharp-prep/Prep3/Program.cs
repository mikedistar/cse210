using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 11);
        int number = 0;
        while (number != magic_number)
        {
            Console.Write("Guess my magic number (it's a whole number): ");
            string guess = Console.ReadLine();
            number = int.Parse(guess);

            if (number > magic_number)
            {
                Console.WriteLine("Guess lower.");
            }
            else if (magic_number > number)
            {
                Console.WriteLine("Guess higher.");
            }
            else
            {
                Console.WriteLine($"You're right! The number is {magic_number}!");
            }
        }

    }
}