using System;

public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Initializes a single-verse reference.
    public Reference(string book, int chapter, int startVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    // Initializes a reference with multiple verses.
    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Overrides the ToString method to format the reference for display.
    public override string ToString() {
        if (_startVerse == _endVerse) {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }
}