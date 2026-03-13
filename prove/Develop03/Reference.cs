using System.Data;
using System.Security.Cryptography;

class Reference
{
private string _reference;

public Reference(string book, int chapter, int verse)
    {
  _reference = $"{book} {chapter}: {verse}";
    }

public Reference(string book, int chapter, int start_verse, int end_verse)
    {
        _reference = $"{book} {chapter}: {start_verse}-{end_verse}";
    }
public string GetReference()
    {
        return _reference;
    }
public void SetReference(string book, int chapter, int verse)
    {
        _reference = $"{book} {chapter}: {verse}";
    }

public void SetReference(string book, int chapter, int start_verse, int end_verse)
    {
        _reference = $"{book} {chapter}: {start_verse}-{end_verse}";
    }
}