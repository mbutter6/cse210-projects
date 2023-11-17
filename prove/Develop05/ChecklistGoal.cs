class ChecklistGoal : Goal
{
    public int Target { get; }
    public int Completions { get; set; }

    public ChecklistGoal(string name, int target) : base(name)
    {
        Target = target;
        Completions = 0;
    }

    public override int GetPoints()
    {
        return (completed && Completions == Target) ? 500 : 50;
    }

    public override void RecordEvent()
    {
        if (!completed)
        {
            Completions++;
            if (Completions == Target)
            {
                completed = true;
                points += GetPoints();
            }
            else
            {
                points += 50; // Points for each completion
            }
        }
    }
}
