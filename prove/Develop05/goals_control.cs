using System;
using System.Collections.Generic;
using System.IO;

public class GoalController
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public int Score
    {
        get { return _score; }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetStatus()} {goal.Name} — {goal.Description}");
            index++;
        }
    }

    public void RecordEvent()
    {
        ShowGoals();
        Console.Write("\nSelect a goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"\nYou earned {points} points!");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.ToFile());
            }
        }

        Console.WriteLine("Goals saved.");
    }
    public void displayFileName(string filename)
    {
        Console.WriteLine($"Current file: {filename}");
    }

    public void Load(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "Simple":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;

                case "Eternal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "Checklist":
                    _goals.Add(new ChecklistGoal(
                        parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])
                    ));
                
                    break;
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
