public class Comment
{
    public string _name;

    public string _comment;

   /*  // public void WriteReadComment(string name, string comment)
    {
        //Comment newComment = new Comment();

        newComment._name = name;

        newComment._comment = comment;

        //_list_of_entries.Add(entry1);
        
    } */

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public Comment()
    {
        _name = "";
        _comment = "";
    }

    public void PrintComment()
    {
         Console.WriteLine($"{_name}\n {_comment}");
    }
}