
using System;
using System.IO;

public class Journal
{
    // Stores a collection of Entry objects representing the journal
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry instance to the journal list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Iterates through all entries and calls their display methods
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the complete journal collection to a text file using a unique separator
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Using ~|~ as a safe delimiter to prevent text collision
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
            }
        }
        Console.WriteLine("Journal successfully saved to file.\n");
    }

    // Loads journal entries from a file, replacing current entries in memory
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear(); // Clear existing entries before loading new ones
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (parts.Length >= 4)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._mood = parts[3];
                
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal successfully loaded from file.\n");
    }
}