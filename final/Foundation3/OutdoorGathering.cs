public class OutdoorGathering : Event
{
    public string WeatherStatement { get; set; }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Outdoor Gathering\nWeather: {WeatherStatement}";
    }
}
