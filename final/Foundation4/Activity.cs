using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _activity;
    protected string _date;
    protected int _minutes;
    protected double _speed;
    protected double _distance;

    public Activity(string activity, string date, int minutes)
    {
        _activity = activity;
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return _distance;
    }

    public virtual double CalculateSpeed()
    {
        return _speed;
    }

    public virtual double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }


    public void DisplayActivity()
    {
        Console.WriteLine($"{_date} {_activity} ({_minutes} min)- Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }
}