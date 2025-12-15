
    public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int Minutes
    {
        get { return _minutes; }
    }

    public abstract double GetDistance(); 
    public virtual double GetSpeed()       
    {
        return GetDistance() / _minutes * 60;
    }

    public virtual double GetPace()        
    {
        return _minutes / GetDistance();
    }

    protected abstract string GetActivityName();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace {GetPace():0.0} min per mile";
    }
}
