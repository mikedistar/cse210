public class CyclingActivity: Activity
{
    // List of CyclingActivity methods/constructors

    public CyclingActivity(string date, double lengthInMinutes, double speedInMiles) : base(date, lengthInMinutes, speedInMiles)
    {
        
    }

    public override double GetDistance()
    {
        return GetSpeedInMiles()/60 * GetLengthInMinutes();
    }

    public override double GetSpeedInMiles()
    {
        return GetUniqueVariable();
    }

    public override double GetPace()
    {
        return 60/GetSpeedInMiles();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthInMinutes():0} minutes)- Distance {GetDistance():0.0} miles, Speed {GetSpeedInMiles():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}