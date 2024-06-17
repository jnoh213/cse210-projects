public class Listing: Activity{
     private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    protected int duration;
    public Listing(int _duration) 
    :base(_duration) {
        duration=_duration;
     }
    public void theList(){
        startMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine(prompts[new Random().Next(prompts.Length)]);
        animation(5);
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"\nYou listed {items.Count} items.");
        endMessage("Listing");
    }
}