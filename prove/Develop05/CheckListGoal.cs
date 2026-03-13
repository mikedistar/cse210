public class CheckListGoal: Goal
{
    private int _bonusPoints;

    private int _timesTillComplete;

    private int _currentProgress;

    public CheckListGoal(string name, string description, int points, int timesTillComplete, int bonusPoints): base(name, description, points)
    {
        _bonusPoints = bonusPoints;

        _timesTillComplete = timesTillComplete;

        _currentProgress = 0;
    }

    public override int RecordEvent()
    {
        _currentProgress ++;

        if (IsComplete())
        {
           return GetPoints() + _bonusPoints;
        }

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _timesTillComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_bonusPoints}, {_timesTillComplete}, {_currentProgress}";
    }

    public void CreateFromString(string name, string description, int points, int bonusPoints, int timesTillComplete, int currentProgress)
    {
        _name = name;

        _description = description;

        _points = points;

        _bonusPoints = bonusPoints;

        _timesTillComplete = timesTillComplete;

        _currentProgress = currentProgress;
    }

    public override string DisplayGoal()
    {
        return $"[{(IsComplete()? 'X':' ')}] {GetName()} ({GetDescription()}) -- Currently completed: {_currentProgress}/{_timesTillComplete}";
    }
}