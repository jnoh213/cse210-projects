using System;
using System.Net.NetworkInformation;
using System.Xml; 

//Needs to have a function that:
/*
Displays a welcome message: "Welcome to the Program"
Asks and returns the users name as a string
Asks for and returns the users favorite number as an int
Accepts an integer as a parameter and returns that number squared
Accepts the users name and the squared number and displays them
*/
class Program
{
    static void Main(string[] args)
    {        
        DisplayMessage();
        string name=PromptUserName();
        int numberFave=favortieNumber();
        double numberSquare=faveNumberSquared(numberFave);
        displayResult(numberSquare,name);
    }
    static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.WriteLine("What is your name?");
        string theName=Console.ReadLine();
        return theName;
    }
    static int favortieNumber(){
        Console.WriteLine("What is your favorite number?");
        int faveNumber=int.Parse(Console.ReadLine());
        return faveNumber;    
    }
    static double faveNumberSquared(int number){
        double newNumber=number*number;
        return newNumber;
    }
    static void displayResult(double squaredNumber, string name){
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}");
    }

}