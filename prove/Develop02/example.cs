using System;

class Program
{
    static void Main(string[] args) { }
    //Journal Prompt Generator



    class Journal
    {
        private List<string> prompts;
        private List<string> entries;

        public Journal()
        {
            prompts = new List<string>
            {
                "Write about your day.",
                "Describe a goal you want to achieve.",
                "What are you grateful for today?",
                "Write about a challenge you faced and how you overcame it.",
                "What's something that made you smile today?",
                "Write about a book or movie you recently enjoyed.",
                "Describe a person who inspires you and why.",
                "Reflect on your favorite childhood memory.",
                "Write about a place you'd like to visit someday.",
                "What are your short-term and long-term goals?",
            };

            entries = new List<string>();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Your Journal!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Get a journal prompt");
                Console.WriteLine("2. Write an entry");
                Console.WriteLine("3. View your journal entries");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetPrompt();
                        break;
                    case "2":
                        WriteEntry();
                        break;
                    case "3":
                        ViewEntries();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        private void GetPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            string prompt = prompts[index];
            Console.WriteLine("\nJournal Prompt:");
            Console.WriteLine(prompt);
        }

        private void WriteEntry()
        {
            Console.WriteLine("\nEnter your journal entry:");
            string entry = Console.ReadLine();
            entries.Add(entry);
            Console.WriteLine("Entry saved!");
        }

        private void ViewEntries()
        {
            Console.WriteLine("\nYour Journal Entries:");

            if (entries.Count == 0)
            {
                Console.WriteLine("No entries yet.");
            }
            else
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    Console.WriteLine($"Entry {i + 1}:\n{entries[i]}\n");
                }
            }
        }
    }

    class Programs
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.Start();
        }
    }
}
























































