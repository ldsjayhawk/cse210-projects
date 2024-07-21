public class Cycle : Activity
{
    // private double _speed;

    public Cycle(string date, int minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _minutes;
        return distance;
    }

    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}