using System;

class Program
{
    static void Main(string[] args)
    {
        //TODO:
        //Create a Journal object 

        //class Journal{}
        Journal myJournal{
            Console.WriteLine(myJournal.JournalName);
        }

        //Prompt the user with menu

        Console.Write("Please choose a number? ");
        string color = Console.ReadLine();

        List<string> prompts = new List<string>();

        prompts.Add("who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        //if user picks option to add new entry
        pubilc void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Get a journal prompt");
                Console.WriteLine("2. Write an entry");
                Console.WriteLine("3. View your journal entries");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetPrompt():
                        break
                    case "2":
            WriteEntry():
                        break;
        case "3":
            ViewEntries():
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

//step 1: pick a random prompt from list above
private void GetPrompt()
{
    Random random = new Random();
    int index = random.Next(prompts.Count);
    string prompt = prompts[index];
    Console.WriteLine("\nJournal Prompt:");
    Console.WriteLine(prompt);
}


//2. display random prompt
// ->   Console.WriteLine
Console.WriteLine("\nEnter your journal entry:");
string entry = Console.ReadLine();

//3. save entry from user
entries.Add(entry);
Console.WriteLine("Entry saved!");
//4. create Response object


//5. save response object to journal object 
entry.Add(journal);
Console.WriteLine("Entry Saved!");

//Step 5.
Entry entry = Entry.Entry();
entry.EntryDate = DateTime.Now.ToShortDateString();
entry.Prompt = "";//from prompt above
entry.Response = ""; // pull from user's response

//Create Journal Entry
Journal journal = new Journal();
journal.JournalName = ""; // ask user for their name
                          //journal.Entries = new List<Entry>();
journal.Entries.Add(entry);

        //save journal to file system
        // possible save it to the txt file

    }
}