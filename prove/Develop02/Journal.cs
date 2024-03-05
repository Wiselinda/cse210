using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public List<Entry> Entries
    {
        get { return entries; }
    }

    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile()
    {
        string filename = "Myjournal.csv";
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    outputFile.WriteLine(entry.ToCsvString());
                }
            }
            Console.WriteLine("Journal entries saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = Entry.Parse(line);
                if (entry != null)
                {
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal entries loaded from file successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No journal entries loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}