using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        //Creates Square object
        Square listShapes1 = new Square("Teal", 3.5);
        shapes.Add(listShapes1);

        //Creates Rectangle object
        Rectangle listShapes2 = new Rectangle("Blue", 9.0, 5.0);
        shapes.Add(listShapes2);

        //Creates Circle object
        Circle listShapes3 = new Circle("Purple", 15.5);
        shapes.Add(listShapes3);

        //Iterates through shapes list and displays color and area
        foreach (Shape s in shapes) {
            //Retrieves color from base class
            string color = s.GetColor();
            //Calculates area per shape from derived class methods
            double area = s.GetArea();
            //Displays the data for each shape
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}