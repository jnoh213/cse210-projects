public class Reflection: Activity{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int duration;
    public Reflection(int _duration) 
    :base(_duration) { 
        duration=_duration;
    }
    public void reflect(){
        startMessage("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine(prompts[new Random().Next(prompts.Length)]);
        int remainingTime = duration;
        while (remainingTime > 0)
        {
            Console.WriteLine(questions[new Random().Next(questions.Length)]);
            animation(5);
            remainingTime -= 5;
        }
        endMessage("Reflection");
    }
}