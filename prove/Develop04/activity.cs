using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity{
    private int _duration;
    public Activity(int duration){
        _duration=duration;
    }
    public void startMessage(string activityName, string description){
        Console.WriteLine($"\nStarting {activityName} Activity");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Prepare to begin...");
        animation(3);
    }
    public void endMessage(string activityName){
        Console.WriteLine($"You have completed another {_duration} seconds of the {activityName} activity");
        animation(3);
    }
    public void animation(int time){
        int x=0;
        int delay=time*100;
        while(x!=time){
            Console.Write("|\b");
            Thread.Sleep(delay);
            Console.Write("\\\b");
            Thread.Sleep(delay);
            Console.Write("-\b");
            Thread.Sleep(delay);
            Console.Write("/\b");
            x+=1;
        }
    }
    
}