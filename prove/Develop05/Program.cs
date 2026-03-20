// Made by Michael Starling
// As something to exceed base requirements, I added a NegativeGoal class which subtracts points from the current score every time the user does it.

using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        int _currentScore = 0;
        int _userInput = -1;
        List<Goal> goals = new List<Goal>();

        while (_userInput != 6)

        {

        
        Console.WriteLine($"You have {_currentScore} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu (1-6): ");

        string _input = Console.ReadLine();

        _userInput = int.Parse(_input);

        switch (_userInput)
        {
            case 1:
                // Code to create goals
                CreateNewGoal();
                break;

            case 2:
                // Code to list goals

                DisplayGoalsAndPoints();
                break;

            case 3:
                // Code to save goals

                Save();
                break;

            case 4:
                // Code to load goals
                
                Console.Write("Type the name of the file you want to load: ");
                string filename = Console.ReadLine();

                Load(filename);
                break;

            case 5:
                // Code to record an event

            int _goalNumber = 0;
            foreach (Goal g in goals)
            {
            _goalNumber ++;
            Console.WriteLine($"{_goalNumber}. {g.DisplayGoal()}");
            }

                Console.WriteLine("Which goal did you compelete: ");
                int _completedGoal = int.Parse(Console.ReadLine());

                Goal _chosenGoal = goals[_completedGoal - 1];

               _currentScore += _chosenGoal.RecordEvent();
                

                break;

            case 6:
                Console.WriteLine("Have a great day! Good luck on your goals!");
                break;

            default:
                Console.WriteLine("Invalid option. Please pick an option from the menu.");
                break;
        }

        }

        void Save()
    {
        // Method for saving goals and points to a file

        Console.Write("Type the name of the file you want to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_currentScore}");
            foreach(Goal goal in goals)
            {
            outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    void Load(string filename)
    {
        // Method for loading goals and points to the program


        string[] lines = System.IO.File.ReadAllLines(filename);

        string line1 = File.ReadLines(filename).First(); // Gets points from file
        _currentScore = int.Parse(line1);

        foreach (string line in lines.Skip(1)) // Gets goals from file
        {
            string[] _types = line.Split(":");
            string _type = _types[0];

            string[] _parts = _types[1].Split(",");
            int _pointsParts = int.Parse(_parts[2]); // get base points from goal here

            if (_type == "SimpleGoal")
                {
                    
                    bool _isComplete = bool.Parse(_parts[3]);
                    SimpleGoal newsimpleGoal = new SimpleGoal("", "" , 0);
                    newsimpleGoal.CreateFromString(_parts[0], _parts[1], _pointsParts, _isComplete);
                    goals.Add(newsimpleGoal);

                }

            else if (_type == "EternalGoal")
                {
                    EternalGoal neweternalGoal = new EternalGoal("", "" , 0);
                    neweternalGoal.CreateFromString(_parts[0], _parts[1], _pointsParts);
                    goals.Add(neweternalGoal);
                }

            else if (_type == "CheckListGoal")
                {
                    CheckListGoal neweternalGoal = new CheckListGoal("", "" , 0, 0, 0);
                    neweternalGoal.CreateFromString(_parts[0], _parts[1], _pointsParts, int.Parse(_parts[3]), int.Parse(_parts[4]), int.Parse(_parts[5]));
                    goals.Add(neweternalGoal);
                }

            else if (_type == "NegativeGoal")
                {
                    NegativeGoal newnegativeGoal = new NegativeGoal("", "" , 0);
                    newnegativeGoal.CreateFromString(_parts[0], _parts[1], _pointsParts);
                    goals.Add(newnegativeGoal);
                }
        }
    }

    void DisplayGoalsAndPoints()
    {

        // Method for displaying goals to the terminal

        int _goalNumber = 0;
        foreach (Goal g in goals)
        {
            _goalNumber ++;
            Console.WriteLine($"{_goalNumber}. {g.DisplayGoal()}");
        }

    }

    void CreateNewGoal()
    {
        // Method used to create goals

        Console.WriteLine("The types of goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine(" 4. Negative Goal");
        Console.WriteLine("What kind of goal would you like to create (1-4): ");
        string _goalType = Console.ReadLine();

        Console.WriteLine("Write the name of your goal: ");
        string _name = Console.ReadLine();

        Console.WriteLine("Write the description of your goal: ");
        string _description = Console.ReadLine();

        Console.WriteLine("Write the number of points you gain/lose for every time you complete the goal (or fail if it's a negative goal): ");
        string _points = Console.ReadLine();

        switch (int.Parse(_goalType))
        {
            case 1:
                // Code for simple goal

                SimpleGoal simpleGoal = new SimpleGoal(_name, _description, int.Parse(_points));
                goals.Add(simpleGoal);
                break;

            case 2:
                // Code for eternal goal

                EternalGoal eternalGoal = new EternalGoal(_name, _description, int.Parse(_points));
                goals.Add(eternalGoal);
                break;

            case 3:
                // Code for checklist goal

                Console.WriteLine("Type how many times you want to complete this goal to get bonus points: ");
                string _timesTillComplete = Console.ReadLine();

                Console.WriteLine($"Type the amount of bonus points that would be earned once you complete this goal {_timesTillComplete} times");
                string _bonusPoints = Console.ReadLine();

                CheckListGoal checkListGoal = new CheckListGoal(_name, _description, int.Parse(_points), int.Parse(_timesTillComplete), int.Parse(_bonusPoints));
                goals.Add(checkListGoal);
                break;

            case 4:
            // Code for negative goal

            NegativeGoal negativeGoal = new NegativeGoal(_name, _description, int.Parse(_points));
            goals.Add(negativeGoal);
            break;

            default:
                Console.WriteLine("Invalid option. Please pick an option from the menu.");
                break;
        }
    }
    }

}