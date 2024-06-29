public class ChecklistGoal : SimpleGoal
{
    private int target; // Number of times the goal needs to be completed
    private int currentCount; // Number of times the goal has been completed
    private int bonusPoints; // Points awarded upon completing the goal

    public ChecklistGoal(string name, int points, bool completed, int timesCompleted, int target, int bonusPoints)
        : base(name, points, completed)
    {
        this.target = target;
        this.currentCount = timesCompleted;
        this.bonusPoints = bonusPoints;
    }

    public override void Complete()
    {
        currentCount++;
        if (currentCount >= target)
        {
            completed = true;
            base.points += bonusPoints; // Add bonus points on completion
        }
    }

    public int GetCurrentCount()
    {
        return currentCount;
    }

    public int GetTarget()
    {
        return target;
    }

    public int GetBonusPoints()
    {
        return bonusPoints;
    }

    public override string Display()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name} - {points} points (completed {currentCount}/{target} times)";
    }
}