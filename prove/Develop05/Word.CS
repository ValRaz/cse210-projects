using System;
using System.Dynamic;

//Stores word text and hidden status
public class Word {
    public string Text {get; private set;}
    public bool IsHidden {get; private set;}
    
    //Constructore to initialize word text and set it as not hidden
    public Word(string text) {
        Text = text;
        IsHidden = false;
    }

    //Displays the word hidden or not
    public string Display {
        get {
            return IsHidden ? "*****": Text;
        }
    }
    
    //Marks word as hidden.
    public void Hide(){
        IsHidden = true;
    }
}