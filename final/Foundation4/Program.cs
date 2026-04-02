using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List <Activity>();

        CyclingActivity cyclingActivity = new CyclingActivity("02 March 2026", 30, 12);
        RunningAcitivty runningAcitivty = new RunningAcitivty("02 April 2026", 45, 8);
        SwimmingActivity swimmingActivity = new SwimmingActivity("01 January 2026", 20, 10);

        activities.Add(cyclingActivity);
        activities.Add(runningAcitivty);
        activities.Add(swimmingActivity);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}