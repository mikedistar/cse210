public class ReceptionEvent : Event
{
    
    // List of ReceptionEvent attributes

    private string _emailForRSVP;

    // List of ReceptionEvent methods/constructors

    public ReceptionEvent(string title, string description, string date, string time, Address address, string emailForRSVP) : base(title, description, date, time, address)
    {
        _emailForRSVP = emailForRSVP;
    }

    public string GetReceptionEventInfo()
    {
        return $"{GetEventStandardDetails()} \n Reception, email: {_emailForRSVP}";
    }

     public string GetReceptionEventShortDescription()
    {
        return $"Reception, {GetTitle()}, {GetDate()}";
    }
}