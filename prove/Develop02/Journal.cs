using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date)
    {
        var journalEntry = new Entry { Prompt = prompt, Response = response, Date = date };
        _entries.Add(journalEntry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

public void Save(string filename)
{
    // Create the file if it doesn't exist
    if (!File.Exists(filename))
    {
        using (File.Create(filename)) { }
    }

    // Write to the file
    using (var writer = new StreamWriter(filename))
    {
        foreach (var entry in _entries)
        {
            writer.WriteLine(entry.Prompt + "|" + entry.Response + "|" + entry.Date);
        }
    }
}

    public void Load(string filename)
    {
        _entries.Clear();
        using (var reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var prompt = parts[0];
                var response = parts[1];
                var date = parts[2];
                var entry = new Entry { Prompt = prompt, Response = response, Date = date };
                _entries.Add(entry);
            }
        }
    }
}
