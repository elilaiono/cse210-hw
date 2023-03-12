using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save and Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewGoals();
                    break;
                case 2:
                    CreateGoal();
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    SaveData();
                    return;
            }
        }
    }

    static void ViewGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (Goal goal in goals)
        {
            Console.Write($"[{(goal is ChecklistGoal ? $"Completed {((ChecklistGoal)goal).CompletedCount}/{((ChecklistGoal)goal).TotalCount}" : " ")}] ");
            Console.WriteLine($"{goal.Type} Goal: {goal.Name} ({goal.Value} points)");
        }
        Console.WriteLine($"Total Score: {score}\n");
    }

    static void CreateGoal()
{
    Console.WriteLine("Select a goal type:");
    Console.WriteLine("1. Simple");
    Console.WriteLine("2. Eternal");
    Console.WriteLine("3. Checklist");
    int type = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter goal name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter goal value:");
    int value = int.Parse(Console.ReadLine());

    Goal goal;
    switch (type)
    {
        case 1:
            goal = new SimpleGoal(name, value);
            break;
        case 2:
            goal = new EternalGoal(name, value);
            break;
        case 3:
            Console.WriteLine("Enter total count:");
            int totalCount = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, value, totalCount);
            break;
        default:
            Console.WriteLine("Invalid goal type.");
            return;
    }

    goals.Add(goal);
    Console.WriteLine($"New {goal.Type} Goal '{name}' added with a value of {value} points.");
}

static void RecordEvent()
{
    Console.WriteLine("Enter the name of the goal you made progress on:");
    string name = Console.ReadLine();

    foreach (Goal goal in goals)
    {
        if (goal.Name == name)
        {
            goal.Complete();
            score += goal.Value;
            return;
        }
    }

    Console.WriteLine($"Goal '{name}' not found.");
}

static void LoadData()
{
    Console.WriteLine("Enter goal data or press enter to continue:");

    while (true)
    {
        Console.WriteLine("Enter goal type (or press enter to finish):");
        string type = Console.ReadLine();
        if (string.IsNullOrEmpty(type)) break;

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal value:");
        int value = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "Simple":
                goals.Add(new SimpleGoal(name, value));
                break;
            case "Eternal":
                goals.Add(new EternalGoal(name, value));
                break;
            case "Checklist":
                Console.WriteLine("Enter total count:");
                int totalCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, totalCount));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}

static void SaveData()
{
    Console.WriteLine("Data saved successfully!");
}
}