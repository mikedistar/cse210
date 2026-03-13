using System.ComponentModel;

public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        IsComplete();
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }

    public void CreateFromString(string name, string description, int points, bool complete)
    {
        _name = name;

        _description = description;

        _points = points;

        _isComplete = complete;
    }

    public override string DisplayGoal()
    {
        return $"[{(GetIsComplete()? 'X':' ')}] {GetName()} ({GetDescription()})";
    }
}