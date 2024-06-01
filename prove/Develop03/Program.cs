using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Scripture theScripture=new Scripture("And he said unto them, Take heed, and beware of covetousness: for a man's life consisteth not in the abundance of the things which he possesseth.");
        Refrence theRefrence= new Refrence("Luke","12","15");

        Scripture multiLineScripture =new Scripture("Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        Refrence multiRefrence=new Refrence("Proverbs", "3","5","6");
          List<Scripture> scriptures = new List<Scripture> { theScripture, multiLineScripture};

        // Randomly select one of the scriptures
        Random rand = new Random();
        Scripture selectedScripture = scriptures[rand.Next(scriptures.Count)];
        while (true)
        {
            // Display the current state of the scripture
            Console.WriteLine(selectedScripture.GetRenderedText());

            // Wait for the user to press Enter or 'q'
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            // Hide a random word in the selected scripture
            selectedScripture.HideRandomWord();
        }
    }
}