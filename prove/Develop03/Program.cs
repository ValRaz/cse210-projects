using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:/Documents/cse210-projects/prove/Develop03/Scriptures.txt";
        var loadedScripture = new Scripture(filePath);

        // Utilizes Word, Reference, and Scripture class to display a scripture, and interact with the user to hide a random word or quit per user input.
        //Demonstrated creativity by including functionality in the classes to account for the hidden status of words so that a word cannot be selected to be 
        //hidden when it is already hidden. Demonstrated creativity by housing a number of scriptures in a txt file, then having the code randomly select a 
        //scripture from the file, load, parse, and display it accordingly. 
        do
        {
            // Creativity demonstration naming and welcome message
            Console.WriteLine("Welcome to MemoRizer! Here is your scripture:");

            loadedScripture.Display();

            var key = Console.ReadLine();

            if (string.Equals(key, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else if (string.IsNullOrWhiteSpace(key))
            {
                loadedScripture.HideRandomWord();
            }
        }
        while (!loadedScripture.AllWordsHidden());

        // Creativity demonstration all hidden exit message
        Console.WriteLine("Congratulations, you've memorized this scripture! Ending program.");
    }
}