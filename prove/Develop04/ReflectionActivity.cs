class ReflectionActivity: Activity
{
    private List<string> _listofQuestions;

    private List<string> _listofFollowUpQuestions;

    private Random _random;

    public ReflectionActivity(int duration, string nameOfActivity) : base(nameOfActivity, duration)
    {
        _random = new Random();

        _listofQuestions = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
           "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _listofFollowUpQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public void StartingRelfectionMessage()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Spinner();
    }
    public void Reflection()
    {
        Console.Clear();
        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        string randomPrompt = _listofQuestions[_random.Next(0, 4)];
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.WriteLine();
        Console.WriteLine("Press enter when you're ready for the follow up question.");
        Console.ReadLine();

        while (currentTime < futureTime)
        {
        string randomFollowUpPrompt = _listofFollowUpQuestions[_random.Next(0, 9)];
        Console.WriteLine($"{randomFollowUpPrompt}");
        Spinner();
            currentTime = DateTime.Now;
        }
        BidFarewell();
    }
}