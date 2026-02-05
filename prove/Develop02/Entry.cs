class Entry
{
    public DateTime date=DateTime.Now;

    public string entry;

    public string prompt;

    public string entries()
    {
        return $"{prompt}\n {entry} \n {date}";
    }
}