using System.Diagnostics;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; 

    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete; 

    }
 
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Great Job completing your goal");
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_isComplete}";
    }
}