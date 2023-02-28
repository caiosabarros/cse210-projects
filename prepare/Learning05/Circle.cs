using System;

class Circle: Shape
{
    private int _radius;
    private float _area;
    public Circle(string cirColor,int radius): base(cirColor)
    {
        _radius = radius;
    }

    public override float GetArea()
    {
       const float PI = (float)Math.PI;
       _area = (PI * _radius * _radius);
       float result = (float)_area;
       return result;
    }
}