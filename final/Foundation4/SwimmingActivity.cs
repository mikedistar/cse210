public class SwimmingActivity: Activity
{

    // List of SwimmingAcitivty methods/constructors

    public SwimmingActivity(string date, double lengthInMinutes, double laps) : base(date, lengthInMinutes, laps)
    {

    }

    public override double GetDistance()
    {
        return  GetUniqueVariable()* 50/1000*0.62;
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
        return $"{GetDate()} Swimming ({GetLengthInMinutes():0} minutes)- Distance {GetDistance():0.0} miles, Speed {GetSpeedInMiles():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}