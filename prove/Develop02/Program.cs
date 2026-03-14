using System;
using System.Collections;
using RandomJournal;

// First create menu system 
// Create date system
// Create journal class to hold the list of entries and the methods to display the entries
// Create entry to store entry, prompt, and date to file with same name
// Create file/file reader
// Create display to print all entries from file with same name
// Create loading to replace all entries in file with same name

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        int choice = Menu();

        while (choice != 5)
        {
            switch (choice)
            {
                case 1:
                    string inspire = prompt.GeneratePrompt();
                    Console.WriteLine($"{inspire}");

                    string response = Console.ReadLine();

                    journal.WriteReadEntry(response, inspire);

                    break;

                case 2:

                    journal.DisplayCurrentEntires();

                    break;

                case 3:
                    journal.LoadEntries();
                    break;

                case 4:
                    journal.SaveEntries();
                    break;

                case 5:
                    Console.WriteLine("Have a wonderful day!");
                    break;

                default:
                    Console.WriteLine("Wrong input, please choose an actual option.");
                    break;
            }


            choice = Menu();
        }


    }

    static int Menu()
    {

        Console.WriteLine(@"""Please select one of the following choices 
1. Write
2. Display
3. Load
4. Save
5. Quit
(Enter 1-5)""");
        int number = int.Parse(Console.ReadLine());
        return number;
    }




}