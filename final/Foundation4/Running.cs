using System;
using System.Reflection;

public class Running : Activity
{

    public Running(string activity, string date, int minutes, int distance) : base(activity, date, minutes)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        double speed = _distance / _minutes * 60;
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();
        return pace;
    }
}