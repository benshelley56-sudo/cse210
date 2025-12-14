public class Event
{
    protected string _title;
    protected string _eventType;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventType, string title, string description, string date, Address address, string time)
    {
        _eventType = eventType;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _title = title;
    }

    public string StandardDetails()
    {
        return $"Event Type: {_eventType}\n" +
            $"Title: {_title}\n" +
            $"Description: {_description}\n" +
            $"Date: {_date}\n" +
            $"Time: {_time}\n" + 
            $"Address: {_address}";
    }

    public virtual string FullDetails()
    {
        return $"{StandardDetails()}" +
        $"Event Type: {_eventType}\n";
            
    }

    public string ShortDescription()
    {
        return $"Event Type: {_eventType}\n" +
            $"Title: {_title}\n" +
            $"Date: {_date}\n";
    }

    
}