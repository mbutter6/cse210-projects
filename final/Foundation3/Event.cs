


public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public Address Address { get; set; }

    public virtual string StandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"{GetType().Name} - {Title}, {Date}";
    }
}
