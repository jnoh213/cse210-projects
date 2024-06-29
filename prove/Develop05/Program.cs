using System;

class Program
{
    static void Main()
    {
        EternalQuest quest = new EternalQuest();

        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine();
            int option;
            if (int.TryParse(choice, out option))
            {
                if (option == 1)
                {
                    CreateSimpleGoal(quest);
                }
                else if (option == 2)
                {
                    CreateEternalGoal(quest);
                }
                else if (option == 3)
                {
                    CreateChecklistGoal(quest);
                }
                else if (option == 4)
                {
                    RecordEvent(quest);
                }
                else if (option == 5)
                {
                    DisplayGoals(quest);
                }
                else if (option == 6)
                {
                    DisplayScore(quest);
                }
                else if (option == 7)
                {
                    SaveGoals(quest);
                }
                else if (option == 8)
                {
                    LoadGoals(quest);
                }
                else if (option == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a simple goal");
        Console.WriteLine("2. Create an eternal goal");
        Console.WriteLine("3. Create a checklist goal");
        Console.WriteLine("4. Record an event");
        Console.WriteLine("5. Display goals");
        Console.WriteLine("6. Display score");
        Console.WriteLine("7. Save goals");
        Console.WriteLine("8. Load goals");
        Console.WriteLine("9. Exit");
        Console.Write("Enter your choice: ");
    }

    static void CreateSimpleGoal(EternalQuest quest)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Invalid input. Enter goal points as a number: ");
        }

        quest.CreateSimpleGoal(name, points);
    }

    static void CreateEternalGoal(EternalQuest quest)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Invalid input. Enter goal points as a number: ");
        }

        quest.CreateEternalGoal(name, points);
    }

    static void CreateChecklistGoal(EternalQuest quest)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Invalid input. Enter goal points as a number: ");
        }

        Console.Write("Enter number of times to complete: ");
        int target;
        while (!int.TryParse(Console.ReadLine(), out target))
        {
            Console.Write("Invalid input. Enter number of times as a number: ");
        }

        Console.Write("Enter bonus points on completion: ");
        int bonusPoints;
        while (!int.TryParse(Console.ReadLine(), out bonusPoints))
        {
            Console.Write("Invalid input. Enter bonus points as a number: ");
        }

        quest.CreateChecklistGoal(name, points, target, bonusPoints);
    }

    static void RecordEvent(EternalQuest quest)
    {
        Console.Write("Enter goal name to record event: ");
        string goalName = Console.ReadLine();
        quest.RecordEvent(goalName);
    }

    static void DisplayGoals(EternalQuest quest)
    {
        quest.DisplayGoals();
    }

    static void DisplayScore(EternalQuest quest)
    {
        quest.DisplayScore();
    }

    static void SaveGoals(EternalQuest quest)
    {
        Console.Write("Enter filename to save: ");
        string saveFile = Console.ReadLine();
        quest.SaveGoals(saveFile);
    }

    static void LoadGoals(EternalQuest quest)
    {
        Console.Write("Enter filename to load: ");
        string loadFile = Console.ReadLine();
        quest.LoadGoals(loadFile);
    }
}
