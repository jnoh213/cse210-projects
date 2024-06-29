using System;
using System.Collections.Generic;
using System.IO;

using System;
using System.Collections.Generic;
using System.IO;

public class EternalQuest
{
    private List<Goal> goals;
    private int totalPoints;

    public EternalQuest()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void CreateSimpleGoal(string name, int points)
    {
        Goal goal = new SimpleGoal(name, points);
        goals.Add(goal);
    }

    public void CreateEternalGoal(string name, int points)
    {
        Goal goal = new EternalGoal(name, points);
        goals.Add(goal);
    }

    public void CreateChecklistGoal(string name, int points, int target, int bonusPoints)
    {
        Goal goal = new ChecklistGoal(name, points, false, 0, target, bonusPoints);
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name() == goalName);
        if (goal != null)
        {
            goal.Complete();
            totalPoints += goal.Points();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter file = new(filename))
        {
            foreach (var goal in goals)
            {
                file.WriteLine($"{goal.GetType().Name},{goal.Name()},{goal.Points()},{goal.Completed()}");
            }
            file.WriteLine($"Total Points: {totalPoints}");
        }
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        using (StreamReader file = new(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts[0] == "Total Points:")
                {
                    totalPoints = int.Parse(parts[1]);
                    continue;
                }

                string goalType = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);
                bool completed = bool.Parse(parts[3]);

                Goal goal = goalType switch
                {
                    "SimpleGoal" => new SimpleGoal(name, points, completed),
                    "EternalGoal" => new EternalGoal(name, points),
                    "ChecklistGoal" => new ChecklistGoal(name, points, completed, 0, 10, 500), // Example default values
                    _ => throw new ArgumentException("Invalid goal type")
                };

                if (completed)
                {
                    goal.Complete();
                }

                goals.Add(goal);
            }
        }
    }
}
