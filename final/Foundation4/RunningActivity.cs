public class RunningAcitivty: Activity
{
    // List of RunningActivity methods/constructors

    public RunningAcitivty(string date, double lengthInMinutes, double distance) : base(date, lengthInMinutes, distance)
    {
        
    }

    public override double GetDistance()
    {
        return GetUniqueVariable();
    }

    public override double GetSpeedInMiles()
    {
        return GetDistance()/GetLengthInMinutes()*60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes()/GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthInMinutes():0} minutes)- Distance {GetDistance():0.0} miles, Speed {GetSpeedInMiles():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}