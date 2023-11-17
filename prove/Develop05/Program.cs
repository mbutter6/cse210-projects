using System;

class Program
{
    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.WriteLine("1. Add new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    ShowScore();
                    break;
                case 5:
                    SaveData();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddNewGoal()
    {
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Choose goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        int type = int.Parse(Console.ReadLine());

        Goal goal;

        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name);
                break;
            case 2:
                goal = new EternalGoal(name);
                break;
            case 3:
                Console.WriteLine("Enter the desired number of completions for the checklist goal: ");
                int target = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, target);
                break;
            default:
                Console.WriteLine("Invalid goal type. Try again.");
                return;
        }


        goal.Add(goal);
        Console.WriteLine($"Goal '{name}' added successfully.");
    }

    static void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you accomplished: ");
        string name = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == name);

        if (goal != null)
        {
            goal.RecordEvent();
            userScore += goal.GetPoints();

            Console.WriteLine($"Event recorded for goal '{name}'. You earned {goal.GetPoints()} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{name}' not found.");
        }
    }

    static void ShowGoals()
    {
        foreach (var goal in goals)
        {
            Console.Write($"[{(goal.IsCompleted() ? "X" : " ")}] {goal.Name} ");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($"Completed {checklistGoal.Completions}/{checklistGoal.Target} times");
            }
            Console.WriteLine();
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"Your current score is: {userScore} points");
    }

    static void SaveData()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.GetPoints()},{goal.IsCompleted()}");
            }
        }

        Console.WriteLine("Data saved successfully.");
    }

    static void LoadData()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');

                    string typeName = data[0];
                    string name = data[1];
                    int points = int.Parse(data[2]);
                    bool completed = bool.Parse(data[3]);

                    Goal goal;

                    switch (typeName)
                    {
                        case nameof(SimpleGoal):
                            goal = new SimpleGoal(name);
                            break;
                        case nameof(EternalGoal):
                            goal = new EternalGoal(name);
                            break;
                        case nameof(ChecklistGoal):
                            int target = int.Parse(data[4]);
                            goal = new ChecklistGoal(name, target);
                            ((ChecklistGoal)goal).Completions = int.Parse(data[5]);
                            break;
                        default:
                            throw new InvalidOperationException("Invalid goal type during loading.");
                    }

                    goal.SetPoints(points);
                    goal.SetCompleted(completed);
                    goals.Add(goal);
                }
            }
        }
    }
}

