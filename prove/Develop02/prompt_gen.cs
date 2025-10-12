

public class Prompt
{

    public List<string> _prompts = new List<string>()
        {
        "What is one lesson you learned this week that you want to remember?",
        "Describe a place where you feel completely at peace. What makes it special?",
        "Write about a person who has influenced your life in a positive way.",
        "What are three things youre grateful for today and why?",
        "If you could travel anywhere in the world right now, where would you go and why?"
        };
    public Random random = new Random();



    public void GetPrompt()
    {
        int P = random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[P]}");


    }


}


