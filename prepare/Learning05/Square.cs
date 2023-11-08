using System;

public class Square : Shape {
    private double _side;

    //Square constructor
    public Square(string color, double side) : base(color) {
        _side = side;
    }

    //Getter to retrieve side length
    public double GetSide() {
        return _side;
    }

    //Setter method to set side length
    public void SetSide(double side) {
        _side = side;
    }

    //Ovverride to calculate the area of the square
    public override double GetArea(){
        return _side * _side;
    }
}