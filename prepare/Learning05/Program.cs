using System;

class Program
{
    static void Main(string[] args)
    {
// Return to the Main method in Program.cs to test your code.
// Create a Square instance, call the GetColor() and GetArea() methods and make sure they return the values you expect.
    Square square = new Square("blue", 5);
    string color = square.GetColor();
    float squareArea = square.GetArea(); 
    Console.WriteLine($"the color is: {color} and area: {squareArea}");  
    //blue and 25!
    Rectangle rec = new Rectangle("green", 5, 10);
    Circle cir = new Circle("yellow", 4);
    float recArea = rec.GetArea();
    float ciArea = cir.GetArea();
    Console.WriteLine($"rec area: {recArea}, cir area: {ciArea}");
    }
}