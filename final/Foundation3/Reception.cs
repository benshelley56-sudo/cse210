public class Reception : Event
{
    private string _email = "";

    public Reception(string eventType, string title, string description, string date, Address address, string time, string email)
        : base(eventType, description, date, time, address, title)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\n" +
            $"RSVP Email: {_email}";
    }


}