using System;
using System.Collections.Generic;
using System.IO;

public class Scripture {
    private Reference _scriptureReference; 
    private List<Word> _words;

    // Gets the reference associated with the scripture.
    public Reference Reference {
        get { return _scriptureReference; }
    }

    // Initializes a scripture with a given reference and list of words.
    public Scripture(Reference scriptureReference, List<Word> words) {
        _scriptureReference = scriptureReference; 
        _words = words;
    }

    // Creativity demonstration: Initializes a random scripture from a file.
    public Scripture(string filePath) {
        var scriptures = LoadScripturesFromFile(filePath);
        var randomScripture = SelectRandomScripture(scriptures);
        _scriptureReference = randomScripture._scriptureReference;
        _words = randomScripture._words;
    }
        //Randomly slects a scripture from the list of loaded scriptures
        private Scripture SelectRandomScripture(List<Scripture> scriptures) {
        var random = new Random();
        var randomIndex = random.Next(scriptures.Count);
        return scriptures[randomIndex];
    }

    // Displays the scripture and reference.
    public void Display() {
        Console.WriteLine(_scriptureReference);
        foreach (var word in _words) {
            if (word.IsHidden) {
                Console.Write("");
            }
            else {
                Console.Write(word.Display + " ");
            }
        }
        Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
    }

    // Hides a random word in the scripture.
    public void HideRandomWord() {
        var random = new Random();
        var unhiddenWords = _words.FindAll(word => !word.IsHidden);
        if (unhiddenWords.Count > 0) {
            var randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }

    // Checks if all words in the current scripture are hidden.
    public bool AllWordsHidden() {
        return _words.TrueForAll(word => word.IsHidden);
    }

    //Creativity demonstration: Parses scripture text and reference from a file.
    private List<Scripture> LoadScripturesFromFile(string filePath) {
        var lines = File.ReadAllLines(filePath);
        var result = new List<Scripture>();

        foreach (var line in lines) {
            var parts = line.Split('|');
            if (parts.Length == 2) {
                var scriptureReference = parts[0].Trim(); 
                var scriptureText = parts[1].Trim();

                var words = scriptureText.Split(' ');
                var wordList = words.Select(w => new Word(w)).ToList();

                var referenceParts = scriptureReference.Split(' ');
                if (referenceParts.Length >= 2) {
                    var book = referenceParts[0];
                    var chapterVerseParts = referenceParts[1].Split(':');
                    if (chapterVerseParts.Length == 2) {
                        var chapter = int.Parse(chapterVerseParts[0]);
                        var verseParts = chapterVerseParts[1].Split('-');
                        if (verseParts.Length == 1) {
                            var verse = int.Parse(verseParts[0]);
                            result.Add(new Scripture(new Reference(book, chapter, verse), wordList));
                        }
                        else if (verseParts.Length == 2) {
                            var startVerse = int.Parse(verseParts[0]);
                            var endVerse = int.Parse(verseParts[1]);
                            result.Add(new Scripture(new Reference(book, chapter, startVerse, endVerse), wordList));
                        }
                    }
                }
            }
            Console.WriteLine("Loaded Scriptures Count: " + result.Count);
        }
        return result;
    }
}    
    