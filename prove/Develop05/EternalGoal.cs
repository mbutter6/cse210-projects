class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name) { }

    public override int GetPoints()
    {
        return 100;
    }

    public override void RecordEvent()
    {
        points += GetPoints();
    }
}
