class Reference
{

private string _book;
private string _chapter;
private string _verses;
private string _verse;
private string _reference;

public Reference()
    {
 _book = "Moroni"; 
 _chapter = "10";
 _verses = "By the power of the Holy Ghost, ye may know the truth of all things.";
 _verse = "5";

 _reference = $"{_book} {_chapter}: {_verse}\n { _verses}";
    }
public string getReference()
    {
        return _reference;
    }
public void setReference(string reference)
    {
        reference = _reference;
    }
}