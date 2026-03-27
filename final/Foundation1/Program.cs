using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // List to contain videos

        List<Video> _videos = new List<Video>();

        Video _firstVideo = new Video();

        Video _secondVideo = new Video();

        Video _thirdVideo = new Video();

        // Declaring the titles of the different videos

        _firstVideo._title = "How to Knit a Sweater";

        _secondVideo._title = "Making a Tank Out of Legos";

        _thirdVideo._title = "Top Ten Games of the Year";

        // Declaring the names of the different authors of the videos

        _firstVideo._author = "Your mom";

        _secondVideo._author = "Your brother";

        _thirdVideo._author = "[Insert name of author here]"; // The name's intentional

        // Declaring the length of the videos in seconds

        _firstVideo._lengthinSeconds = 900;

        _secondVideo._lengthinSeconds = 85;

        _thirdVideo._lengthinSeconds = 500;

        // Adding the videos to the list

        _videos.Add(_firstVideo);
        _videos.Add(_secondVideo);
        _videos.Add(_thirdVideo);

        Comment _firstSweaterComment = new Comment("Sammy", "I love sweaters!");

        Comment _secondSweaterComment = new Comment("Alvin", "I hate sweaters. Why does this video exist?");

        Comment _thirdSweaterComment = new Comment("Bob", "First comment!");

        // Declaring the names of the authors of the sweater comments

        _firstSweaterComment._name = "Sammy";

        _secondSweaterComment._name = "Alvin";

        _thirdSweaterComment._name = "Bob";

        // Declaring what the sweater commenters wrote

        _firstSweaterComment._comment = "I love sweaters!";

        _secondSweaterComment._comment = "I hate sweaters. Why does this video exist?";

        _thirdSweaterComment._comment = "First comment!";

        // Adding sweater comments to the sweater video

        _firstVideo.AddComments(_firstSweaterComment);

        _firstVideo.AddComments(_secondSweaterComment);

        _firstVideo.AddComments(_thirdSweaterComment);

        Comment _firstTankComment = new Comment();

        Comment _secondTankComment = new Comment();

        Comment _thirdTankComment = new Comment();

        // Declaring the names of the commenters on the Tank video

        _firstTankComment._name = "Brian";

        _secondTankComment._name = "Cathrine";

        _thirdTankComment._name = "Derick";

        // Declaring what the tank commenters wrote

        _firstTankComment._comment = "I love Legos";

        _secondTankComment._comment = "That's the coolest looking tank I've seen.";

        _thirdTankComment._comment = "First comment!";

        // Adding Tank comments to the Tank video

        _secondVideo.AddComments(_firstTankComment);

        _secondVideo.AddComments(_secondTankComment);

        _secondVideo.AddComments(_thirdTankComment);

        // Declaring Game comments

        Comment _firstGameComment = new Comment();

        Comment _secondGameComment = new Comment();

        Comment _thirdGameComment = new Comment();

        // Declaring the names of the Game commenters

        _firstGameComment._name = "Evan";

        _secondGameComment._name = "Francis";

        _thirdGameComment._name = "Gilbert";

        // Declaring what the Game commenters wrote

        _firstGameComment._comment = "The first one is my favourite";

        _secondGameComment._comment = "You should make another video, this one's awesome!";

        _thirdGameComment._comment = "First comment!";

        // Adding Game comments to Game video

        _thirdVideo.AddComments(_firstGameComment);

        _thirdVideo.AddComments(_secondGameComment);

        _thirdVideo.AddComments(_thirdGameComment);

        // Loop to print out each video and their comments

        foreach(Video video in _videos)
        {
            video.PrintVideoInfo();
            Console.WriteLine();
        }
    }
}