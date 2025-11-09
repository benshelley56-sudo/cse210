
using System.ComponentModel;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public string setName()
    {

        return _activityName;
    }
    public string setdescription()
    {
        return _description;
    }
    public int setduration()
    {

        return _duration;
    }
    public int OpeningMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n\n{_description}\n\nHow long in seconds would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }
    public void ClosingMessage()
    {
        Console.WriteLine($"\n\nWell Done!\n\nYou have completetd another {_duration} Seconds of your session");
    }

    public void SpinnerAnimation()
    {
        int spinnerloop = 0;
        

            List<string> spinner = new List<string>();
            spinner.Add("_");
            spinner.Add("_");
            
            
            Console.Write($"\nBe prepared, Activity will begin soon\nLoading");
            while (spinnerloop < 4)
            {
                foreach (string s in spinner)

                {
                    Console.Write(s);
                    Thread.Sleep(500);
                }
            spinnerloop ++;
            }
        Console.WriteLine("Done!");
            Thread.Sleep(1200);
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(1);
        while (DateTime.Now < endTime)
        {
        }
    }
}