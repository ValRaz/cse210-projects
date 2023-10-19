using System;
using System.Collections.Concurrent;

//Stores the scripture reference information
public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    //Constructor for single verse reference
    public Reference(string book, int chapter, int startVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    //Constructor for multiple verse reference
    public Reference (string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //Overrides the ToString method to format the reference
    public override string ToString() {
        if (_startVerse == _endVerse) {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
    }
}