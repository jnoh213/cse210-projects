public abstract class Goal
{
    protected string name;
    protected int points;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract string Name();
    public abstract int Points();
    public abstract bool Completed();
    public abstract void Complete();
    public abstract string Display();
}