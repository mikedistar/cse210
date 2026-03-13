public class NegativeGoal: Goal
{
    public NegativeGoal(string name, string description, int points): base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return -GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
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