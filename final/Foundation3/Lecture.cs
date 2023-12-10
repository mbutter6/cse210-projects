public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
