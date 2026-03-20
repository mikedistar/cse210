using System.Runtime.CompilerServices;

class Scripture
{

    private Reference _reference;

    private string _text;
    Random _random = new Random();
    private List<Word> _words = new List<Word>();
    int _lengthOfList = 0;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        foreach (string word in _text.Split(' '))
        {
            Word word1 = new Word(word);
            _words.Add(word1);

            _lengthOfList ++;
        }
    }

    public void PrintReference()
    {
        Console.WriteLine($"{_reference.GetReference()}");
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

        // Picks random words to hide in scripture

       Word _chosenWord1 = _words[_random.Next(0, _lengthOfList)];
       Word _chosenWord2 = _words[_random.Next(0, _lengthOfList)];
       Word _chosenWord3 = _words[_random.Next(0, _lengthOfList)];

       // Those words hide themselves

       _chosenWord1.HideWord();
       _chosenWord2.HideWord();
       _chosenWord3.HideWord();

       foreach(Word _word in _words)
        {
           Console.Write($" {_word.RenderText()}");
        }


    }
    public bool CheckIfAllIsHidden()
    {
        int _numberOfShownWords = 0;
        foreach (Word _word in _words)
        {
            if (_word.GetIsHidden() == false)
            {
                _numberOfShownWords ++;
            }
        }

    if(_numberOfShownWords > 0)
            {
                return false;
            }

            else
            {
                return true;
            
            }
    }
}