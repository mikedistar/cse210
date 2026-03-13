using RandomJournal;

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
         Console.Write("Type the name of the file you want to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in list_of_entries)
            {
            outputFile.WriteLine($"{entry.prompt}, {entry.entry}, {entry.date}");
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
                prompt = _parts[0],
                entry = _parts[1],
                date = DateTime.Parse(_parts[2])

            };
            list_of_entries.Add(newEntry);        
            }
    }

    
}