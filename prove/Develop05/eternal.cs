public class EternalGoal : Goal
{

    private int _attempts;
    public EternalGoal(string name, string description, int points, int attempts = 0)
        : base(name, description, points)
    {
        _attempts = attempts;
    }

    public override int RecordEvent()
    {
        _attempts++;
        return Points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStatus()
    {
        return $"[{_attempts}]";
    } 

    public override string ToFile()
    {
        return $"Eternal|{Name}|{Description}|{Points},";
    }
}
