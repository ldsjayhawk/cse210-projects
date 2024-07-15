using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color, side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}