using System;

public abstract class Shape {
    private string _color;

    //Shape class constructor
    public Shape(string color) {
        _color = color;
    }

    //Getter to retrieve color of the shape
    public string GetColor() {
        return _color;
    }

    //Setter to set color of the shape
    public void SetColor(string color) {
        _color = color;
    }

    //Abstract method to return the area of a shape (to be overridden in derived classes)
    public abstract double GetArea();
}