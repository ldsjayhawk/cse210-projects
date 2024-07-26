using System.Diagnostics;
using System.Runtime.InteropServices;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private bool _isComplete;
    private int _current;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
        _isComplete = false;

        // _amountCompleted = 0; 
    }

    public ChecklistGoal(string name, string description, int points, bool isComplete, int current, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
        _isComplete = isComplete;

        // _amountCompleted = 0; 
    }

    public override int RecordEvent()
    {
        _current ++;
        if (_current == _target)
        {
            _isComplete = true;
            Console.WriteLine($"Great Job completing your goal.  You earned {_points}");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine("Good job completing a target.  You earned {_points}");
            return _points;
        }
    }


    public override bool IsComplete()
    {
        return _isComplete; 
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"Completed: {_current} out of {_target}";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"|{_isComplete}|{_current}|{_target}|{_bonus}";
    }

}