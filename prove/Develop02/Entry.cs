using System;

public class Entry {
    public string Date {get; set;}

    public string Content {get; set;}

   //Constructor to initialize the date and content of an entry
    public Entry (string date, string content) {
        Date = date;
        Content = content;
    }

    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Content: {Content}\n");
    }
}