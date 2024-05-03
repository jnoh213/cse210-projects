using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {
        string done="incomplete";
        Console.WriteLine("Enter a List of numbers, type 0 when finished.");
        List<int> numbers=new List<int>();
        int total=0;
        int times=0;
        int largest=0;
        while (done!="complete"){
            Console.WriteLine("Enter a Number: ");
            string stringNumber;
            stringNumber=Console.ReadLine();
            int realNumber= int.Parse(stringNumber);
            numbers.Add(realNumber);
            if (stringNumber=="0"){
                foreach(int number in numbers){
                    total+=number;
                    times++;
                    if (number>largest){
                        largest=number;
                    }
                }

                done="complete";
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total/times}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}