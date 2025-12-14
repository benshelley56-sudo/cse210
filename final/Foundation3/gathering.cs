public class Gathering : Event
{
    private string _weatherForecast;

    public Gathering(string eventType, string title, string description, string date, Address address, string time, string weatherForecast)
        : base(eventType, description, date, time, address, title)
    {
        _weatherForecast = weatherForecast;
    }
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\n" +
            $"Weather Forecast: {_weatherForecast}";
    }

}


