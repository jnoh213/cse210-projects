public class SimpleGoal : Goal
{
    protected bool completed;

    public SimpleGoal(string name, int points, bool completed = false) : base(name, points)
    {
        this.completed = completed;
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
        return completed;
    }

    public override void Complete()
    {
        completed = true;
    }

    public override string Display()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name} - {points} points";
    }
}