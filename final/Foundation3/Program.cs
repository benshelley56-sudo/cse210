public class Program
{
    public static void Main()
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("55 Sunset Blvd", "Los Angeles", "CA", "USA");
        Address addr3 = new Address("999 Oak Lane", "Boulder", "CO", "USA");

        Event[] events =
        {
            //I used chat gpt just to help me generate the data for these events
            new Lectures("Lecture", "Future of AI","A discussion on upcoming AI technologies.","April 12, 2025",addr1,"10:00 AM","Dr. Jane Smith",150),

            new Reception("Reception", "Spring Networking Gala","A social gathering for business professionals.","May 2, 2025", addr2, "7:00 PM","rsvp@galaevents.com"),

            new Gathering("Gathering", "Community Picnic","Family-friendly picnic with food and games.","June 20, 2025", addr3, "12:00 PM","Sunny with a light breeze")
        };

        Console.Clear();
        foreach (Event e in events)
        {
            Console.WriteLine(" -------------- \n");
            Console.WriteLine("standard description: ");
            Console.WriteLine(e.StandardDetails());

            Console.WriteLine("\nfull description: ");
            Console.WriteLine(e.FullDetails());

            Console.WriteLine("\nshort description: ");
            Console.WriteLine(e.ShortDescription());

        }
    }
}