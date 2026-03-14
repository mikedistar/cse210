class Entry
{
    public DateTime _date=DateTime.Now;

    public string _entry;

    public string _prompt;



    public string entries()
    {
        return $"{_prompt}\n {_entry} \n {_date}";
    }
}