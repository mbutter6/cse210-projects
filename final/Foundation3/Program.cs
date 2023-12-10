using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each event type
        var lectureEvent = new Lecture
        {
            Title = "Machine Learning Workshop",
            Description = "Introduction to ML",
            Date = new DateTime(2023, 3, 15),
            Time = new DateTime().Add(new TimeSpan(14, 30, 0)),
            Address = new Address { Street = "123 ML Street", City = "Cityville", State = "ML", ZipCode = "54321" },
            Speaker = "John Doe",
            Capacity = 50
        };

        var receptionEvent = new Reception
        {
            Title = "Networking Mixer",
            Description = "Connect and Network",
            Date = new DateTime(2023, 4, 20),
            Time = new DateTime().Add(new TimeSpan(18, 0, 0)),
            Address = new Address { Street = "456 Networking Avenue", City = "Metropolis", State = "Network", ZipCode = "67890" },
            RsvpEmail = "rsvp@example.com"
        };

        var outdoorEvent = new OutdoorGathering
        {
            Title = "Summer Picnic",
            Description = "Enjoy the Sun and Fun",
            Date = new DateTime(2023, 6, 10),
            Time = new DateTime().Add(new TimeSpan(12, 0, 0)),
            Address = new Address { Street = "789 Park Lane", City = "Sunnytown", State = "Sun", ZipCode = "12345" },
            WeatherStatement = "Weather-dependent event; check for updates."
        };

        // Display marketing messages
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine("\n---\n");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine("\n---\n");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine(outdoorEvent.ShortDescription());
    }
}









































