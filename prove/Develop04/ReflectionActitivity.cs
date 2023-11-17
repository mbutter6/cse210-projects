public class ReflectionActivity : Activity
{
    public string ReflectionIntroduction { get; set; }




    public void GetReflection()
    {
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.Write("Enter the duration in seconds: ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

            string[] prompts = {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

            Random random = new Random();

            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nReflect on this: " + prompts[random.Next(prompts.Length)]);
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine("\nReflection activity completed. Thank you for participating!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid duration in seconds.");
        }
    }


}

