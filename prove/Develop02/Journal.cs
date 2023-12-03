public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        entries.Add(new Entry(parts[1], parts[2]) { Date = date });
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. No entries loaded.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading entries: {ex.Message}");
        }
    }
}
