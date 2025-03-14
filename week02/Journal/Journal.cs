public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} - Prompt: {entry._promptText}\n{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); 

        string[] lines = File.ReadAllLines(file);
        
        for (int i = 0; i < lines.Length; i += 2)
        {
            if (i + 1 < lines.Length)
            {
                string dateAndPrompt = lines[i]; 
                string response = lines[i + 1];  

                string[] parts = dateAndPrompt.Split(new[] { " - Prompt: " }, StringSplitOptions.None);
                
                if (parts.Length == 2) 
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0].Trim(),
                        _promptText = parts[1].Trim(),
                        _entryText = response.Trim()
                    };

                    _entries.Add(entry);
                }
            }
        }

        Console.WriteLine($"Journal loaded from {file}");
    }
}