public class Journal
{
    public string JournalName { get; set; }

    public List<Entry> Entries { get; set; } //control click entry takes you to that class. Links to entry class


    public Journal()
    {
        Entries = new List<Entry>();

    }
}




