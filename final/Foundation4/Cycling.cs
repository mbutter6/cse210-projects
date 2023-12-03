// Cycling.cs
using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => speed * GetMinutes() / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;

    protected override string GetDetails()
    {
        return $"Speed: {speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min per mile";
    }
}
