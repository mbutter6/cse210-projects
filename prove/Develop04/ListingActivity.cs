public class ListingActivty : Activity
{
    public string ListingIntroduction { get; set; }


    public void GetLists()
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.Write("Enter the duration in seconds: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("This activity will help you make a list of the good things in your life by listing as many as you can in a certain area.");

            string[] prompts = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random random = new Random();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            Console.WriteLine("Get ready to start listing. You can begin now.");

            int itemCounter = 0;

            while (DateTime.Now < endTime)
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine("\n" + prompt);
                Thread.Sleep(5000); // Pause for 5 seconds

                Console.Write("Enter an item (or press Enter to skip): ");
                if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    itemCounter++;
                }
            }

            Console.WriteLine($"\nYou listed {itemCounter} items.");
            Console.WriteLine("\nListing activity completed. Thank you for participating!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration in seconds.");
        }
    }
}


