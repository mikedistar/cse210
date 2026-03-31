public class LectureEvent : Event
{
    
    // List of LectureEvent attributes

    private string _speaker;

    private int _capacity;

    // List of LectureEvent methods/constructors

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        
        _speaker = speaker;

        _capacity = capacity;
    }

    public string GetLectureEventInfo()
    {
        return $"{GetEventStandardDetails()} \n Lecture, Speaker: {_speaker}, Capacity: {_capacity}";
    }

    public string GetLectureEventShortDescription()
    {
        return $"Lecture, {GetTitle()}, {GetDate()}";
    }
}