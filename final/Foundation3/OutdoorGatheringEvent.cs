public class OutdoorGatheringEvent : Event
{
    
    // List of OutdoorGatheringEvent attributes

    private string _predictedWeather;

    // List of OutdoorGatheringEvent methods/constructors

    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string predictedWeather) : base(title, description, date, time, address)
    {
        _predictedWeather = predictedWeather;
    }

    public string GetOutdoorGatheringEventInfo()
    {
        return $"{GetEventStandardDetails()} \n Outdoor Gathering, {_predictedWeather}";
    }

    public string GetOutdoorGatheringEventShortDescription()
    {
        return $"Outdoor Gathering, {GetTitle()}, {GetDate()}";
    }
}