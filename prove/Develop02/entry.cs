public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd HH:mm:ss}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}
