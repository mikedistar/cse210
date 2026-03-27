public class Video
{
    public string _title;

    public string _author;

    public int _lengthinSeconds;

   List<Comment> _comments = new List<Comment>();

   public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountNumberOfComments()
    {
        int _numberOfComments = 0;

        foreach(Comment comment in _comments)
        {
            _numberOfComments ++;
        }
        return _numberOfComments;
    }

    public void PrintComments()
    {
        foreach(Comment comment in _comments)
        {
            comment.PrintComment();
        }
    }

    public void PrintVideoInfo()
    {
        string _videoInfo = $"Title: {_title}\n Author: {_author}\n Length in seconds: {_lengthinSeconds}\n Number of comments: {CountNumberOfComments()}\n";
        
        Console.WriteLine(_videoInfo);
        PrintComments();
    }
}