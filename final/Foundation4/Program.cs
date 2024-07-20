using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activity objects
        Activity running = new Running("2024-07-01", 30, 3.0);
        Activity cycling = new Cycling("2024-07-02", 45, 15.0);
        Activity swimming = new Swimming("2024-07-03", 60, 20);

        // Store activities in a list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
