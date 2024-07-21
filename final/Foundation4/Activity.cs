using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _date;
    protected int _minutes;
    protected double _speed;
    protected double _distance;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        double distance = _speed * _minutes;
        return distance;
    }

    public virtual double CalculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public virtual double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }


    public void DisplayActivity()
    {
        Console.WriteLine($"{_date} Running (30 min)- Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }
}