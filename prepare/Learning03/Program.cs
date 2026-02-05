using System;
using System.Diagnostics;

class Program
{


    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine("Hello Learning03 World!");

        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetTop()}");
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetTop()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

        Fraction fractionRandom = new Fraction();
         Random randomGenerator = new Random();

        for (int i = 0 ; i < 20 ; i ++)
        {
            int top = randomGenerator.Next(1, 100);
            int bottom = randomGenerator.Next(1, 100);
            fractionRandom.SetTop(top);
            fractionRandom.SetBottom(bottom);
            Console.WriteLine($"Fraction {i+1}: string: {fractionRandom.GetFractionString()} Number: {fractionRandom.GetDecimalValue()}");
            
        }

        
    }
}