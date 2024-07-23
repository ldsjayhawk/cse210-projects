public class Cycling : Activity
{
    // private double _speed;

    public Cycling(string activity, string date, int minutes, int speed) : base(activity, date, minutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }

}