using System;
using System.Collections.Generic;
using System.IO;


class Program
{
   static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine($"You have {totalPoints} points."); 
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static int GetMenuChoice()
    {
        return int.Parse(Console.ReadLine());
    }
    static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create: ");

        int goalType = int.Parse(Console.ReadLine());
        switch (goalType)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }
    }

   static void CreateSimpleGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int value = int.Parse(Console.ReadLine());
        goals.Add(new SimpleGoal(name, value));
    }

    static void CreateEternalGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the amount points associatd with this goal? ");
        int value = int.Parse(Console.ReadLine());
        goals.Add(new EternalGoal(name, value));
    }

    static void CreateChecklistGoal()
    {
        Console.WriteLine("What is the anme of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is the amount points associated with this goal? ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int totalTimes = int.Parse(Console.ReadLine());
        goals.Add(new ChecklistGoal(name, value, totalTimes));
    }

    static void ListGoals()
    {
        foreach (Goal goal in goals)
        {
            string status = goal.Completed ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal.GetStringRepresentation()}");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Goal goal = goals.Find(g => g.Name == name);
        if (goal != null)
        {
            goal.Complete();
            totalPoints += goal.Value;
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Goal not found");
        }
    }

    static void LoadGoals()
    {
        try
        {
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                string name = parts[0];
                int value = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);
                int timesCompleted = 0;
                if (parts.Length == 4)
                {
                    timesCompleted = int.Parse(parts[3]);
                }

                if (timesCompleted > 0)
                {
                    goals.Add(new ChecklistGoal(name, value, timesCompleted));
                }
                else if (completed)
                {
                    goals.Add(new SimpleGoal(name, value) { Completed = completed });
                }
                else
                {
                    goals.Add(new EternalGoal(name, value));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
}