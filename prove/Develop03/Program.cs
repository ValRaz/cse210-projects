using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        string filePath = "Scriptures.txt";
        var loadedScripture = new Scripture(filePath);

        // Utilizes Word, Reference, and Scripture class to display a scripture, and interact with the user to hide a random word or quit per user input.
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