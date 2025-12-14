using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 12, 12), 30, 3.0),
            new Cycling(new DateTime(2025, 12, 12), 45, 15.0),
            new Swimming(new DateTime(2025, 12, 12), 40, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}