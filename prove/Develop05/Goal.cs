using System.ComponentModel;

public abstract class Goal
{
    protected string _name;

    protected string _description;

    protected int _points;

    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;

        _description = description;

        _points = points;

        _isComplete = false;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract string GetStringRepresentation();

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public abstract string DisplayGoal();

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }



}