using System.Security.Cryptography.X509Certificates;

class Activity
{

    private string _nameOfActivity;

    private int _duration;
    public Activity(string nameOfActivity, int duration)
    {
        _nameOfActivity = nameOfActivity;

        _duration = duration;
    }
    public void Spinner()
    {

        for (int i = 4; i > 0; i -- )
        {
        Console.Write("/");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("—");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("\\");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");
        }
    }
    public void CountDown()
    {
        Console.Write("How long do you want the activty to last: ");
        string time = Console.ReadLine();
        _duration = int.Parse(time);
        Console.Clear();
        Console.WriteLine("Get ready... ");
        Spinner();
    }
    public void BidFarewell()
    {
        Console.WriteLine($"Congrats! you did {_duration} seconds of the {_nameOfActivity} activity!");
        Spinner();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetNameOfActivity()
    {
        return _nameOfActivity;
    }
}