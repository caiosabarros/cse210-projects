using System;

class Rectangle: Shape
{
    // Repeat the steps above for the Rectangle and Circle classes, putting them each in their own files, storing the necessary variables, and overriding the GetArea() for each.
    int _firstSide;
    int _secSide;
    public Rectangle(string recColor, int firstSide, int secSide): base(recColor)
    {
        _firstSide = firstSide;
        _secSide = secSide;
    }

    public override float GetArea()
    {
        return _firstSide * _secSide;
    }
}