using System;

public class Scripture {
    //Stores scripture reference
    public Reference Reference {get;}
    //Stores list of words in a scripture
    private List<Word> _words {get;}

    //Constructor for a specific scripture
    public Scripture(Reference reference, List<Word> words) {
        Reference = reference;
        _words = words;
    }

    //Loads random scripture from a file
    public Scripture(string filePath) {
        //Load scriptures from file
        var scriptures = LoadScripturesFromFile(filePath);

        //Select a random scripture.
        var random = new Random();
        var randomIndex = random.Next(scriptures.Count);
        var selectedScripture = scriptures[randomIndex];

        //Initialzes current scripture's reference and words
        Reference = selectedScripture.Reference;
        _words = selectedScripture._words;
    }

    //Display the scripture and reference
    public void Display() {
        Console.WriteLine(Reference);
        foreach (var word in _words) {
            if (word.IsHidden) {
                Console.Write("*****");
            }
            else {
                Console.Write(word.Display + " ");
            }
        }
        Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
    }

    //Hides a random word in the scripture.
    public void HideRandomWord() {
        var random = new Random();
        var unhiddenWords = _words.FindAll(word => !word.IsHidden);

        if (unhiddenWords.Count > 0) {
            var randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }

    //Checks if all words in the current scripture are hidden
    public bool AllWordsHidden() {
        return _words.TrueForAll(word => word.IsHidden);
    }

    //Parses scripture text and reference from file
    private List<Scripture> LoadScripturesFromFile(string filePath) {
        var lines = File.ReadAllLines(filePath); // Use File.ReadAllLines directly
        var result = new List<Scripture>();

        foreach (var line in lines) {
            var parts = line.Split('|');
            if (parts.Length == 2) {
                var reference = parts[0].Trim();
                var scriptureText = parts[1].Trim();

                // Creates Word objects from the scripture text
                var words = scriptureText.Split(' ');
                var wordList = words.Select(w => new Word(w)).ToList();

                // Parse the reference to create a Reference object
                var referenceParts = reference.Split(' ');
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
        }
        return result;
    }
}    
    