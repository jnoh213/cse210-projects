using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int the_number = randomGenerator.Next(1, 101);

        // Console.WriteLine("What is the Magic Number");
        // string string_number=Console.ReadLine();
        // int the_number=int.Parse(string_number);

        string correct="incorrect";

        int guesses=0;

        while(correct!="correct"){
        Console.WriteLine("What is your guess?");

        string guess=Console.ReadLine();

        int the_guess=int.Parse(guess);

        if (the_number==the_guess){
            Console.WriteLine($"You guessed it in {guesses} attempts!");

            Console.WriteLine("Do you want to play again?");
            string repeat=Console.ReadLine();
            if (repeat=="Yes"|| repeat=="y"){
                the_number = randomGenerator.Next(1, 101);
            }
            else{
                correct="correct";
            }
            
        }
        else if (the_number>the_guess){
            Console.WriteLine("Higher");
            guesses++;
        }
        else{
            Console.WriteLine("Lower");
            guesses++;
        }
        }
        
    }
}