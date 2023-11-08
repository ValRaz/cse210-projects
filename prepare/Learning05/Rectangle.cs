using System;

public class Rectangle : Shape {
    private double _width;
    private double _height;

    //Rectange constructor
    public Rectangle (string color, double width, double height) : base(color) {
        _width = width;
        _height = height;
    }

    //Getter to retrieve the width
    public double GetWidth() {
        return _width;
    }

    //Getter to retreive the Height
    public double GetHeight() {
        return _height;
    }

    //Setter method to set width
    public void SetWidth(double width) {
        _width = width;
    }

    //Setter method to set height
    public void SetHeight(double height) {
        _height = height;
    }

    //Override to calculate area of the rectangle
    public override double GetArea() {
        return _width * _height;
    }
}