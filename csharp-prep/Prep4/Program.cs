using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int largest_number = 0;
        int total = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a whole number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                total += 1;
                if (number > largest_number)
                {
                    largest_number = number;
                }
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum/total}");
        Console.WriteLine($"The largest number is {largest_number}");

    }
}