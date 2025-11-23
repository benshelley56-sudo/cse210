public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount >= _targetCount)
            return Points + _bonus;

        return Points;
    }

   public override bool IsComplete()
{
    return _currentCount >= _targetCount;
}

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} Completed {_currentCount}/{_targetCount}";
    }

    public override string ToFile()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{_targetCount}|{_bonus}|{_currentCount},";
    }
}
