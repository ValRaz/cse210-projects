using System;

public class Word {
    private string _text;
    private string _displayText;
    private bool _isHidden;

    // Gets the text of the word.
    public string Text {
        get { return _text; }
        private set { _text = value; }
    }

    // Indicates whether the word is hidden.
    public bool IsHidden {
        get { return _isHidden; }
        private set { _isHidden = value; }
    }

    // Initializes a new Word with the given text and sets it as not hidden.
    public Word(string text) {
        _text = text;
        _displayText = text;
        _isHidden = false;
    }

    // Gets the word to display, taking into account its hidden status.
    public string Display {
        get {
            if (_isHidden) {
                return new string('_', _text.Length);
            }
            return _displayText;
        }
    }

    // Marks the word as hidden and updates the display text.
    public void Hide() {
        _isHidden = true;
        _displayText = new string('_', _text.Length);
    }
}