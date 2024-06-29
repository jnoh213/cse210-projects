public class EternalGoal : Goal
{
    private int repetitions; // Number of times the goal has been completed

    public EternalGoal(string name, int points) : base(name, points)
    {
        repetitions = 0;
    }

    public override string Name()
    {
        return name;
    }

    public override int Points()
    {
        return points;
    }

    public override bool Completed()
    {
        return false; // Eternal goals are never fully completed
    }

    public override void Complete()
    {
        repetitions++;
    }

    public int GetRepetitions()
    {
        return repetitions;
    }

    public override string Display()
    {
        return $"[ ] {name} - {points} points (repeated {repetitions} times)";
    }
}
