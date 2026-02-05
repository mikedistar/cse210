namespace RandomJournal
{
    public class PromptGenerator
    {
        string[] _prompts =
        {
            "Describe the most interesting person you met today. ",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",

        };

        public string GeneratePrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _prompts.Length);

                return _prompts[number];


        }
    }
}

