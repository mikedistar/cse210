using RandomJournal;

class Journal

{

    List<Entry> _list_of_entries = new List<Entry>(); 

    public void WriteReadEntry(string entry, string prompt)
    {
        Entry entry1 = new Entry();

        entry1._entry = entry;

        entry1._prompt = prompt;

        _list_of_entries.Add(entry1);
        
    }

    public void DisplayCurrentEntires()
    {
        foreach (Entry entry1 in _list_of_entries)
        {
            Console.WriteLine($"\n{entry1.entries()}\n");
        }
    }

    public void SaveEntries()
    {
         Console.Write("Type the name of the file you want to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _list_of_entries)
            {
            outputFile.WriteLine($"{entry._prompt}, {entry._entry}, {entry._date}");
            }
        }
    }

    public void LoadEntries()
    {
        Console.Write("Type the name of the file you want to save: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] _parts = line.Split(", ");
            Entry newEntry = new Entry
            {
                _prompt = _parts[0],
                _entry = _parts[1],
                _date = DateTime.Parse(_parts[2])

            };
            _list_of_entries.Add(newEntry);        
            }
    }

    
}