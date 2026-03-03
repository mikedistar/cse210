using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        int _userInput = -1;

        BreathingActivity breathingactivity = new BreathingActivity(4, 6, 30, "breathing");
        ReflectionActivity reflectionactivity = new ReflectionActivity(30, "reflection");
        ListeningActivity listeningactivity = new ListeningActivity(30, "listening");


        while (_userInput != 4)
        {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfullness Activity.");
        Console.WriteLine("Please select an activity: ");
        Console.WriteLine("1. Breathing exercise");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listening activity");
        Console.WriteLine("4. Quit");
        string input = Console.ReadLine();
        _userInput = int.Parse(input);
        

        switch (_userInput)
        {
            case 1:
            breathingactivity.StartingBreathingMessage();
            breathingactivity.CountDown();
            breathingactivity.Breathing();
            break;
            case 2:
            reflectionactivity.StartingRelfectionMessage();
            reflectionactivity.CountDown();
            reflectionactivity.Reflection();
            break;
            case 3:
            listeningactivity.StartingListeningMessage();
            listeningactivity.CountDown();
            listeningactivity.Listening();
            break;
            case 4:
            Console.WriteLine("Have a good day!");       
                    
            break;
            default:
            Console.WriteLine("Not a valid option.");
            break;
        
        }

        }
        

    }
}