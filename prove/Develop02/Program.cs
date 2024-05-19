using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal =new Journal();
        bool Done = false;
        while (!Done)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option");
            string theChoice =Console.ReadLine();
            if (theChoice=="1"){
                journal.WriteEntry();
            }
            else if (theChoice =="2"){
                journal.DisplayJournal();
            }
            else if (theChoice =="3"){
                Console.Write("Enter filename to save: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
            else if (theChoice =="4"){
                Console.Write("Enter filename to load: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFile(loadFileName);
            }
            else if (theChoice =="5"){
                Done=true;
            }
            else{
                System.Console.WriteLine("Please choose a correct number.");
            }

        }
    }
}