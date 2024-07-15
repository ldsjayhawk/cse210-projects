using System.Diagnostics;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Shape
{
    protected string _color;
    protected double _side;

    public Shape(string color, double side)
    {
        _color = color;

    }

    public string GetColor()
    {
        return _color;
    }

    public virtual double GetArea()
    {

        return 0;
    }


}