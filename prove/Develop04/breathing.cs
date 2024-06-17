public class Breathing: Activity
{
    protected int _duration;
    public Breathing(int duration)
    :base(duration){
        _duration=duration;
    }

    public void repeat(){
        startMessage("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int remainingTime = _duration;
        while(remainingTime>0){
            Console.Write("Breathe in... ");
            countdown(5);
            remainingTime-=5;
            Console.Write("Breathe out... \b");
            countdown(5);
            Console.WriteLine();
            remainingTime-=5;
        }
        endMessage("Breathing");
    }
    public void countdown(int interval){
        int x=interval;
        while(x>0){
            Console.Write($"{x}\b");
            Thread.Sleep(1000);
            x-=1;
        }
    }
}