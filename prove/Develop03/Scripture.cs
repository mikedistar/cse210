class Scripture
{

    private Reference _reference;

    private string _text;

    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        foreach (string word in _text.Split(' '))
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }


    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public void HideWords()
    {



        Console.Clear();


    }
    public void CheckIfAllIsHidden()
    {

    }
}