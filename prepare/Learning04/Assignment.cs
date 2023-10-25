public class Assignment
{
    public string StudentName { get; set; }
    public string Topic { get; set; }

    public void GetSummary()
    {
        Console.WriteLine($"{StudentName} - {Topic}");
    }
}