public class Activity
{
    private DateTime date;
    private int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public DateTime GetDate() => date;
    public int GetMinutes() => minutes;

    // Virtual methods for calculation
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    // GetSummary method
    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - {GetDetails()}";
    }

    // Abstract method to be implemented in derived classes for additional details
    protected virtual string GetDetails()
    {
        return $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
