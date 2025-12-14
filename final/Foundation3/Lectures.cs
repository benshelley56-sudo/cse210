public class Lectures : Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lectures(string eventType, string title, string description, string date, Address address, string time, string speaker, int capacity)
        : base(eventType, description, date, time, address, title)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\n" +
            $"Speaker: {_speaker}\n" +
            $"Capacity: {_capacity}";
    }

}