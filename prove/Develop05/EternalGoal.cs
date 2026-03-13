using System.ComponentModel;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
    }

    public void CreateFromString(string name, string description, int points)
    {
        _name = name;

        _description = description;

        _points = points;
    }
    public override string DisplayGoal()
    {
        return $"[{(GetIsComplete()? 'X':' ')}] {GetName()} ({GetDescription()})";
    }

}