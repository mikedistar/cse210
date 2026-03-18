using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>(); // Holds the list of scriptures

        // Different references

        Reference moroni = new Reference("Moroni", 10, 4, 5);
        Reference alma = new Reference("Alma", 7, 11);
        Reference nephi = new Reference("1 Nephi", 3, 7);
        Reference helaman = new Reference("Helaman", 5, 12);
        Reference mosiah = new Reference("Mosiah", 2, 17);

        // Different scriptures with text and reference

        Scripture moroni10 = new Scripture(moroni, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        Scripture alma7 = new Scripture(alma, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");
        Scripture nephi3 = new Scripture(nephi, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Scripture helaman5 = new Scripture(helaman, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        Scripture mosiah2 = new Scripture(mosiah, "17 And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");

        // Adding scriptures to scritpures list

        scriptures.Add(moroni10);
        scriptures.Add(alma7);
        scriptures.Add(nephi3);
        scriptures.Add(helaman5);
        scriptures.Add(mosiah2);

        int number = random.Next(0,4);

        Scripture chosenScripture = scriptures[number];


        string _userInput = "";

        chosenScripture.PrintReference();
        Console.WriteLine($"{chosenScripture.GetText()}");

        while (_userInput != "quit" & chosenScripture.CheckIfAllIsHidden() != true)
        {
        Console.WriteLine();
        Console.WriteLine("Press ENTER or type 'quit' to exit.");
        _userInput = Console.ReadLine();

            if (_userInput != "quit" & chosenScripture.CheckIfAllIsHidden() != true)
            {
                Console.Clear();
                chosenScripture.PrintReference();
                chosenScripture.HideWords();
                chosenScripture.CheckIfAllIsHidden();
                Console.WriteLine();
            }
        }
    }

}