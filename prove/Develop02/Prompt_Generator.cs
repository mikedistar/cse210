namespace RandomJournal
{
    public class PromptGenerator
    {
        string[] _prompts =
        {
            "Describe the most interesting person you met today. ",
            "What am I most thankful for today? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the best part of my day? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today... what would it be? ",
            "What was my biggest accomplishment? ",
            "What was the most delicious thing I ate today? ",
            "What was the hardest thing you did today? "

        };

        public string GeneratePrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _prompts.Length);

                return _prompts[number];


        }
    }
}

