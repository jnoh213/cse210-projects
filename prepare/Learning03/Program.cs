using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFrac=new Fraction();
        double theDouble=0.0;
        myFrac.onlyTop(5);
        Console.WriteLine(myFrac.GetFractionToString());
        theDouble=myFrac.GetDecimalValue();
        Console.WriteLine($"{theDouble}");
        myFrac.onlyTop(5);
        Console.WriteLine(myFrac.GetFractionToString());
        theDouble=myFrac.GetDecimalValue();
        Console.WriteLine($"{theDouble}");
        myFrac.bothNumbers(3,4);
        Console.WriteLine(myFrac.GetFractionToString());
        theDouble=myFrac.GetDecimalValue();
        Console.WriteLine($"{theDouble}");
        myFrac.bothNumbers(1,3);
        Console.WriteLine(myFrac.GetFractionToString());
        theDouble=myFrac.GetDecimalValue();
        Console.WriteLine($"{theDouble}");
    }
}