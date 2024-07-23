public class Swimming : Activity
{
    private int _laps;

    public Swimming(string activity, string date, int minutes, int laps) : base(activity, date, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
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
