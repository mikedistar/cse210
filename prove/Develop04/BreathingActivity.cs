using System.Security.Cryptography.X509Certificates;

class BreathingActivity: Activity
{
    private int _breatheinTime = 4;

    private int _breatheoutTime = 6;

public BreathingActivity(int breatheinTime, int breatheoutTime, int duration, string nameOfActivity) : base(nameOfActivity, duration)
    {
        _breatheinTime = breatheinTime;

        _breatheoutTime = breatheoutTime;
    }    
    

    
    public void StartingBreathingMessage()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Spinner();
    }

    public void BreathingCountdown()
    {

        Console.Write("Breathe in ");
        
        for (int breathin = 4; breathin > 0; breathin -- )
        {
        Console.Write($"{breathin}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
        Console.WriteLine("");
        Console.Write("Breathe out ");
        for (int breatheout = 6; breatheout > 0; breatheout --)
        {
        Console.Write($"{breatheout}");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
        Console.WriteLine("");
        
    }
    public void Breathing()
    {
       int duration = GetDuration();
       Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            BreathingCountdown();
            currentTime = DateTime.Now;
        }
        BidFarewell();
        }
        }