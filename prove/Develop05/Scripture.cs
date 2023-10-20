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

    //Parses the reference from the file
    private Reference ParseReference(string referenceText) {
        var parts = referenceText.Trim().Split(" ");
        if (parts.Length >= 2) {
            var book = parts[0];
            var referenceParts = parts[1].Split(":");

            if (referenceParts.Length ==2) {
                var chapter = int.Parse(referenceParts[0]);
                var verseParts = referenceParts[1].Split("-");

                if (verseParts.Length == 1) {
                    var startVerse = int.Parse(verseParts[0]);
                    return new Reference(book, chapter, startVerse);
                }
                else if (verseParts.Length == 2) {
                    var startVerse = int.Parse(verseParts[0]);
                    var endVerse = int.Parse(verseParts[1]);
                    return new Reference(book, chapter, startVerse, endVerse);
                }
            }
        }
        return null;
    }

    //Loads scriptures from file
    private List<Scripture> LoadScripturesFromFile(string filepath) {
        var result = new List<Scripture>();
        var lines = File.ReadAllLines(filepath);

        Reference currentReference = null;
        List<Word> currentWords = new List<Word>();

        foreach (var line in lines) {
            if (string.IsNullOrWhiteSpace(line)) {
                continue;
            }
            if (currentReference == null) {
                currentReference = ParseReference(line);
            }
            else {
                currentWords.AddRange(ParseScripture(line));
            }

            if (string.IsNullOrWhiteSpace(line) && currentReference != null) {
                var scripture =  new Scripture(currentReference, currentWords);
                result.Add(scripture);
                currentReference = null;
                currentWords.Clear();
            }

            if (currentReference != null && currentWords.Any()) {
                var scripture = new Scripture(currentReference, currentWords);
                result.Add(scripture);
                currentReference = null;
                currentWords.Clear();
            }
        }

        return result;
    }
    //Parses the scripture text from the file
    private List<Word> ParseScripture(string scriptureText) {
        var lines = scriptureText.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        var scriptureWords = new List<Word>();

        var referenceAdded = false;
        var scriptureTextBuilder = new StringBuilder();

        foreach (var line in lines) {
            var trimmedLine = line.Trim();
            
            if (!referenceAdded) {
                scriptureWords.Add(new Word(trimmedLine));
                referenceAdded = true;
            }
            else if (string.IsNullOrWhiteSpace(trimmedLine)) {
                if(scriptureTextBuilder.Length > 0) {
                    var words = scriptureTextBuilder.ToString().Split(" ");
                    foreach (var word in words) {
                        scriptureWords.Add(new Word(word));
                    }
                    scriptureTextBuilder.Clear();
                }
            }
            else {
                if (scriptureTextBuilder.Length > 0) {
                    scriptureTextBuilder.Append(" ");
                }
                scriptureTextBuilder.Append(trimmedLine);
            }
        }
        if (scriptureTextBuilder.Length > 0) {
            var words = scriptureTextBuilder.ToString().Split(" ");
            foreach (var word in words) {
                scriptureWords.Add(new Word(word));
            }
        }

        return scriptureWords;
    }
}