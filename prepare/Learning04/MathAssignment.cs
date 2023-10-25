public class MathAssignment : Assignment
{

    public string TextbookSection { get; set; }

    public string Problem { get; set; }

    public void GetHomeworkList()
    {
        Console.WriteLine($"{TextbookSection} - {Problem}");
    }

    //string Summary { get; set; }
}