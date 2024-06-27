public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
      foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveFile(string file)
    {
        using (StreamWriter sw = new StreamWriter (file))
        {
            foreach(Entry entry in _entries)
            {
                sw.WriteLine($"{entry._entryDate}|{entry._location}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFile(string file)
    {
        _entries.Clear();
        string [] lines = File.ReadAllLines(file);
        foreach(string line in lines)
        {
            string [] parts = line.Split("|");
            Entry entry = new Entry();
            entry._entryDate = parts[0];
            entry._location = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];
            _entries.Add(entry);
        }
    }
}
