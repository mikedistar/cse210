class Word
{
    private string _word;

    private bool _isHidden;

    public Word(string word, bool isHidden = false)
    {
        _word = word;

        _isHidden = isHidden;
    }

public void HideWord()
    {
        _isHidden = true;
    }

public void ShownWord()
    {
        _isHidden = false;
    } 

public bool GetIsHidden()
    {
        return _isHidden;
    } 
public string RenderText()
    {
        if(_isHidden)
    {
        return new string('_', _word.Length);
    }
        return _word;
    }
}