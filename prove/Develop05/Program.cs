using System;

class Program
{
    static void Main(string[] args)
    {
        var filePath = "C:/Users/nutca/OneDrive/Documents/cse210-projects/prove/Develop05/Scriptures.txt";
        var scripture = new Scripture(filePath);

        //Utilizes Word, Reference, and Scripture class to display a scripture, and interact with the user to hide a random word or quit per user input. 
        do {
            Console.WriteLine("Welcome to MemoRizer! Here is your scripture:");

            scripture.Display();
            
            var key = Console.ReadLine();
            
            if (string.Equals(key,"quit", StringComparison.OrdinalIgnoreCase)) {
                break;
            }
            else if (string.IsNullOrWhiteSpace(key)) {
                scripture.HideRandomWord();
            }
        }
        while (!scripture.AllWordsHidden());

        Console.WriteLine("Congratulations you've memorized this scripture! Ending program.");
    }
}