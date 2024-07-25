using System.Diagnostics;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) :  base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        Console.WriteLine("Good job!");
        return _points;
    }

}