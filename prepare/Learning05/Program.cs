using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to hold shapes
        List<Shape> shapesList = new List<Shape>();

        //Add a square, rectangle, and circle to shapesList
        shapesList.Add(new Square("Teal", 7.0));
        shapesList.Add(new Rectangle("Purple", 9.0, 5.0));
        shapesList.Add(new Circle("Green", 15.5));

        //Iterate through shapesList
        foreach (Shape shape in shapesList) {
            
            //Display the color and area of each shape
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }    
}