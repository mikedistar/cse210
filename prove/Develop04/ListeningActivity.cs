class ListeningActivity: Activity
{
    private List<string> _listofPrompts;

    private int _numberofPrompts = 0;

    private Random _random;

    public ListeningActivity(int duration, string nameOfActivity) : base(nameOfActivity, duration)
    {
        _random = new Random();

        _listofPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void StartingListeningMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Spinner();
    }
    public void Listening()
    {
        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        string randomFollowUpPrompt = _listofPrompts[_random.Next(0, 4)];
        Console.WriteLine($"{randomFollowUpPrompt}");
        Console.Write("Enter an entry: ");
        Console.ReadLine();
        _numberofPrompts++;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("\nEnter another entry: ");
            Console.ReadLine();
            _numberofPrompts ++;
        }
        Console.WriteLine($"\nYou entered {_numberofPrompts} entries!");
        BidFarewell();
    }
}