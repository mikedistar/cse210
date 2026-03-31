public class Event
{
    
    // List of Event attributes

    private string _title;

    private string _description;

    private string _date;

    private string _time;

    private Address _address;
    
    // List of Event attributes/constructors

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;

        _description = description;

        _date = date;

        _time = time;

        _address = address;
    }

    public string GetEventStandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address.GetAddress()}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }
}