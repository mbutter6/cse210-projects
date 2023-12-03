using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            do
            {
                Console.Clear();
                scripture.DisplayScripture();

                Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("All words are hidden. Exiting...");
                    break;
                }
            } while (!scripture.AllWordsHidden());
        }
    }

}
