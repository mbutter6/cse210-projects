public class WritingAssignment : Assignment
{
    public string Title { get; set; }

    // public string summary { get; set; }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{Title}");

    }


}