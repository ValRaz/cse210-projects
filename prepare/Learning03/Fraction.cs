using System;

public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator) {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator) {
        _top = numerator;
        _bottom = denominator;
    }

    public int Top {
        get {return _top;}
        set { _top = value;}
    }

    public int Bottom {
        get { return _bottom;}
        set { _bottom = value;}
    }

    public string GetFractionString() {
        string data = $"{_top}/{_bottom}";
        return data;
    }

    public double GetDecimalValue() {
        return (double)_top / (double)_bottom;
    }
}