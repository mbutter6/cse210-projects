class SimpleGoal : Goal
{
    public SimpleGoal(string name) : base(name) { }

    public override int GetPoints()
    {
        return 1000;
    }

    public override void RecordEvent()
    {
        completed = true;
    }
}
