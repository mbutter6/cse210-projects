abstract class Goal
{
    public string Name { get; }
    protected int points;
    protected bool completed;

    public Goal(string name)
    {
        Name = name;
        points = 0;
        completed = false;
    }

    public abstract int GetPoints();

    public void SetPoints(int value)
    {
        points = value;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public void SetCompleted(bool value)
    {
        completed = value;
    }

    public abstract void RecordEvent();
}
