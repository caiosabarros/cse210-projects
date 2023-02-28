// Create the _side attribute as a private member variable.
using System;

// In a new file, create the Square class.
// Make sure this class inherits from the base class.
class Square: Shape
{
// Create a constructor that accepts the color and the side, and then call the base constructor with the color.
    protected int _side = 0;
    public Square(string color, int sideLength): base(color)
    {
        _side = sideLength;
    }
// Override the GetArea() method from the base class and fill in the body of this function to return the area.
    public override float GetArea()
    {
        return (_side * _side);
        //Console.WriteLine($"area is:{_side * _side}");
    }
}