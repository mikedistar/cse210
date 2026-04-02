using System.Runtime.InteropServices;

public abstract class Activity
{
    
    // List of Activity attributes

    private string _date;

    private double _lengthInMinutes;

    private double _distance;

    private double _speedInMiles;

    private double _pace;

    private double _uniqueVariable;

    // List of Activity methods/constructors

    public Activity(string date, double lengthInMinutes, double uniqueVariable)
    {

        _date = date;

        _lengthInMinutes = lengthInMinutes;

        _uniqueVariable = uniqueVariable;
    }

    public abstract double GetDistance();

    public abstract double GetSpeedInMiles();

    public abstract double GetPace();

    public abstract string GetSummary();

    public double GetUniqueVariable()
    {
        return _uniqueVariable;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }
}