using System;

public class Circle : Shape {
    private double _radius;

    //Cicrle Constructor
    public Circle(string color, double radius) :  base(color) {
        _radius = radius;
    }

    //Getter to retreive the radius
    public double GetRadius() {
        return _radius;
    }

    //Setter method to set the radius
    public void SetRadius(double radius) {
        _radius = radius;
    }

    //Override to calculate area of the circle
    public override double GetArea() {
        return Math.PI *_radius * _radius;
    }
}