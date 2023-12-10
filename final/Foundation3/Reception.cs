
public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}
