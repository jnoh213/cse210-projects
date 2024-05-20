using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

class Journal{
    private List<string> _prompts =new List<string> {
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you overcame it.",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    private List<string> _inputs= new List<string>();
    private List<DateTime> _timestamps=new List<DateTime>;
    public void WriteEntry()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        string adding=Console.ReadLine();
        _inputs.Add(adding);
        _timestamps.Add(DateTime.Now);
    }
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Inputs:");
        for (int i = 0; i < _inputs.Count; i++)
        {
            Console.WriteLine($"[{_prompts[i]} {_timestamps[i]}] {_inputs[i]}");
        }
    }
    public void SaveToFile(string fileName){
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < _inputs.Count; i++)
            {
                writer.WriteLine($"{_timestamps[i]}|{_prompts[i]}|{_inputs[i]}");
            }
        }
        System.Console.WriteLine("File saved!");
    }
    public void LoadFile(string fileName){
        _inputs.Clear();
        _timestamps.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _timestamps.Add(DateTime.Parse(parts[0]));
                    _prompts.Add(parts[1]);
                    _inputs.Add(parts[2]);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}