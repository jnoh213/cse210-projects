using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                Breathing activity = new Breathing(duration);
                activity.repeat();
            }
            else if (choice == "2")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                Reflection activity = new Reflection(duration);
                activity.reflect();
            }
            else if (choice == "3")
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                Listing activity = new Listing(duration);
                activity.theList();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Have a mindful day!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        
        
    }
}