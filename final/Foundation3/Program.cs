using System;

class Program
{
    static void Main(string[] args)
    {

        {
            Address eventAddress = new Address
            {
                Street = "123 Main St",
                City = "Cityville",
                State = "Stateville",
                ZipCode = "12345"
            };

            Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", new DateTime(2023, 12, 10), new TimeSpan(14, 30, 0), eventAddress, "John Doe", 50);

            Reception receptionEvent = new Reception("Networking Night", "Networking event with professionals", new DateTime(2023, 12, 15), new TimeSpan(18, 0, 0), eventAddress, "rsvp@example.com");

            OutdoorGathering outdoorEvent = new OutdoorGathering("Park Picnic", "Casual picnic in the park", new DateTime(2023, 12, 20), new TimeSpan(12, 0, 0), eventAddress, "Expect sunny weather");

            Console.WriteLine("Lecture Event:\n");
            Console.WriteLine(lectureEvent.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n");
            Console.WriteLine(lectureEvent.GetFullDetails());
            Console.WriteLine("\nShort Description:\n");
            Console.WriteLine(lectureEvent.GetShortDescription());

            Console.WriteLine("\n\nReception Event:\n");
            Console.WriteLine(receptionEvent.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n");
            Console.WriteLine(receptionEvent.GetFullDetails());
            Console.WriteLine("\nShort Description:\n");
            Console.WriteLine(receptionEvent.GetShortDescription());

            Console.WriteLine("\n\nOutdoor Gathering Event:\n");
            Console.WriteLine(outdoorEvent.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n");
            Console.WriteLine(outdoorEvent.GetFullDetails());
            Console.WriteLine("\nShort Description:\n");
            Console.WriteLine(outdoorEvent.GetShortDescription());
        }
    }

}
