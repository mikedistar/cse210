class Journal

{

    List<Entry> list_of_entries = new List<Entry>(); 

    public void WriteReadEntry(string entry, string prompt)
    {
        Entry entry1 = new Entry();

        entry1.entry = entry;

        entry1.prompt = prompt;

        list_of_entries.Add(entry1);
        
    }

    public void DisplayCurrentEntires()
    {
        foreach (Entry entry1 in list_of_entries)
        {
            Console.WriteLine($"\n{entry1.entries()}\n");
        }
    }

    public void SaveEntries()
    {
        
    }

    public void LoadEntries()
    {
        
    }

    
}