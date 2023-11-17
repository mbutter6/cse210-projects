using System;

class Program
{
    static void Main(string[] args)
    {
        //TODO:
        //Create a Journal object 
        Journal myjournal = new Journal();
        Console.WriteLine(myjournal.Entries);

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
        //bool Journal(myjournal == '1'){

        //}



        //step 1: pick a random prompt from list above
        //2. display random prompt
        // ->   Console.WriteLine
        //3. save entry from user
        //4. create Response object

        //5. save response object to journal object 


        //Step 5.
        Entry entry = Entry.GetEntry();
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