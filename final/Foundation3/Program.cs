using System;

class Program
{
    static void Main(string[] args)
    {
        // Hardcoding vlaues for addresses

        Address address = new Address("Liberty St", "Free Ville", "Texas", "USA");
        Address address1 = new Address("Random Directions and Numbers St", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("End Of The Rd", "End Of The World", "Province", "Antartica");

        // Setting up values for each different kind of event

        LectureEvent lectureEvent = new LectureEvent("Devotional", "Listen to a prophets voice", "3/31/2026", "11:30", address1, "Brother Lindford", 1000);
        ReceptionEvent receptionEvent = new ReceptionEvent("Graduation", "Come celebrate our daughter's graduation!", "4/9/2026", "7:00 pm", address, "madeupemail@madeupemail.com");
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("Collecting Samples", "Collect dirt, snow, and bacterial samples with us!", "12/1/2026", "Forever", address2, "Clear weather");

        // Printing out each kind of message for the lecture event

        Console.WriteLine($"{lectureEvent.GetEventStandardDetails()}"); // Prints standard details
        Console.WriteLine();
        Console.WriteLine($"{lectureEvent.GetLectureEventInfo()}"); // Prints all details
        Console.WriteLine();
        Console.WriteLine($"{lectureEvent.GetLectureEventShortDescription()}"); // Prints short description
        Console.WriteLine();

        // Printing out each kind of message for the reception event

        Console.WriteLine($"{receptionEvent.GetEventStandardDetails()}"); // Prints standard details
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetReceptionEventInfo()); // Prints all details
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetReceptionEventShortDescription()); // Prints short description
        Console.WriteLine();

        // Printing out each kind of message for the outdoor gathering event

        Console.WriteLine($"{outdoorGatheringEvent.GetEventStandardDetails()}"); // Prints standard details
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GetOutdoorGatheringEventInfo()); // Prints all details
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringEvent.GetOutdoorGatheringEventShortDescription()); // Prints short description
    }
}