using System.Diagnostics;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public virtual bool IsComplete()
    {
        return false;
    }
    

    public virtual string GetDetailsString()
    {
        string tick;
        if (IsComplete())
            tick = "X";
        else
            tick = " ";
            
        return $"[{tick}] {_goalName} {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_goalName}|{_description}|{_points}";
    }
}



