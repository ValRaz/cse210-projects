using System;

public class Journal {
    public List<Entry> entries;
    public PromptGenerator promptGenerator;

    //Constructor to initialize and empty list of entries
    public Journal() {
        entries = new List<Entry>();
        //Initializes the prompt generator
        promptGenerator = new PromptGenerator();
    }

    //Adds a new entry to the journal from user input
    public void AddEntry(string date) {
        
        string prompt = promptGenerator.GenerateRandomPrompt();
        Console.WriteLine($"Today's Prompt: {prompt}");

        string content = Console.ReadLine();

        Entry entry = new Entry(date, content);
        entries.Add(entry);
    }

    //Displays all entries
    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            entry.DisplayEntry();
        }
    }

    //Saves Entries to a file
    public void SaveToFile(string filename) {
        
    }
}