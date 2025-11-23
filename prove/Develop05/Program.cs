using System;

class Program
{
    static void Main()
    {
        GoalController control = new GoalController();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"You have {control.Score} Points\n");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal(control);
                    break;

                case 2:
                    control.ShowGoals();
                    break;

                case 3:
                    control.RecordEvent();
                    break;

                case 4:
                    
                    Console.Write("Filename: ");
                    control.Save(Console.ReadLine());
                    break;

                case 5:
                    Console.Write("\nFilename: ");
                    control.Load(Console.ReadLine());
                    break;
            }
        }
    }

    static void CreateGoal(GoalController manager)
    {
        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a type: ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;

            case 2:
                manager.AddGoal(new EternalGoal(name, description, points));
                break;

            case 3:
                Console.Write("How many until complete: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points(past the amount requred): ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }
}

