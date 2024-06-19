public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._promptText}*{e._entryText}*{e._date}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            // asterisks for partitioning since commas are commonly used in writing
            string[] parts = line.Split("*");

            Entry newEntry = new Entry();
            newEntry._promptText = parts[0];
            newEntry._entryText = parts[1];
            newEntry._date = parts[2];

            this.AddEntry(newEntry);
        }
    }
}