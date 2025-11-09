
using System.Runtime.InteropServices;

public class Breathing : Activity
{
    public Breathing(string activityName, string description, int duration) 
            : base(activityName, description, duration)
    {
    }

    public void BreathingActivity()
    {
        int breathloop = 0;
        while (breathloop < 4)
        {


            Console.Write($"\nBreathe in...");
            
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.Write($"\nBreathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
        breathloop ++;
        }
    }
}


