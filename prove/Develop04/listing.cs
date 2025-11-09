public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List some of your favorite movies ",
        "List your favorite sports",
        "List your favorite consperacy theories",
        "List your favorite foods",
        "List your favorite hobbies"
    };

    public Listing(string activityName, string description, int duration)
            : base(activityName, description, duration)
    {
    }

    public void ListingActivity()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        string selectedPrompt = _prompts[promptIndex];

        Console.WriteLine($"\nConsider the following prompt:\n\n--- {selectedPrompt} ---\n\nYou have {_duration} seconds to list your responses. Start listing now!");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
    }
    
}