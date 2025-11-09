

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment when you helped someone in need.",
        "Reflect on a personal achievement that you are proud of.",
        "Remember a time when you learned something new about yourself.",
        "Think about a situation where you showed kindness to others."
    };
    public Reflection(string activityName, string description, int duration)
            : base(activityName, description, duration)
    {
    }

    public void ReflectionActivity()
    {
        Random rand = new Random();
        int promptIndex = rand.Next(_prompts.Count);
        string selectedPrompt = _prompts[promptIndex];

        Console.WriteLine($"\nConsider the following prompt:\n\n--- {selectedPrompt} ---\n\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself from this experience?",
            "How can you apply what you learned to future situations?"
        };

        foreach (string question in questions)
        {
            Console.Write($"\n{question}\n");
            for (int i = 9; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1800);
                Console.Write("\b \b");
            }
        }
    }

}