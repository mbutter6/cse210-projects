public class Activity
{
    public string ActivityName { get; set; }

    public string ActivityOptions { get; set; }

    //public string ChooseActivity = Console.ReadLine("Please enter an activity:"):

    public string StartMessage { get; set; }

    public string EndMessage { get; set; }

    public void Menu()
    {
        Console.WriteLine($"Please select one of the following Activities:");
        string chooseActivity = Console.ReadLine();


    }
}












