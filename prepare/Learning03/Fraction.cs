using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

public int GetTop()
{
    return _top;
}

public void SetTop(int top)
{
    _top = top;    
}

public int GetBottom()
{
    return _bottom;
}

public void SetBottom(int bottom)
{
    _bottom = bottom;
}

public string GetFractionString()
{
    string fraction = _top + " / " + _bottom;
    return fraction;
}

public double GetDecimalValue()
{
    double decimalValue = (_top / _bottom);
    decimalValue = Math.Round(decimalValue);
    return decimalValue;
}
}