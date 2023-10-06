using System;

public class Entry {
    public string _dateCreated {get;}
    public string _content {get;}

   //Initializes the date and content of an entry from user input
    public Entry (string dateInput, string content) {
        _dateCreated = dateInput;
        _content = content;
    }

    //Displays the content of an entry
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateCreated}");
        Console.WriteLine($"Content: {_content}\n");
    }
}