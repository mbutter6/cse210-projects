using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your response to the prompt: ");
                    string response = Console.ReadLine();
                    string[] prompts = { "Who was the most interesting person I interacted with today?",
                                         "What was the best part of my day?",
                                         "How did I see the hand of the Lord in my life today?",
                                         "What was the strongest emotion I felt today?",
                                         "If I had one thing I could do over today, what would it be?" };
                    string randomPrompt = prompts[new Random().Next(prompts.Length)];
                    journal.AddEntry(randomPrompt, response);
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter a filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully.");
                    break;

                case "4":
                    Console.Write("Enter a filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully.");
                    break;

                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
