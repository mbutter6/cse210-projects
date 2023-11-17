public class BreathingActivity : Activity
{
    public string BreathingIntroduction { get; set; }

    public void GetBreathing()
    {
        {
            Console.WriteLine("Welcome to the Breathing Activity!");
            Console.Write("Enter the duration in seconds: ");

            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(1000); // Pause for 1 second
                Console.Write("3 ");
                Thread.Sleep(1000);
                Console.Write("2 ");
                Thread.Sleep(1000);
                Console.WriteLine("1 ");
                Thread.Sleep(1000);

                Console.WriteLine("Breathe out...");
                Thread.Sleep(1000);
                Console.Write("3 ");
                Thread.Sleep(1000);
                Console.Write("2 ");
                Thread.Sleep(1000);
                Console.WriteLine("1 ");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Breathing activity completed. Feel refreshed!");
        }

    }
}



