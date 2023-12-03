public class Scripture
{
    private Reference reference;
    private Verse verse;

    public Scripture(string referenceText, string verseText)
    {
        reference = new Reference(referenceText);
        verse = new Verse(verseText);
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{reference.Text}:");
        verse.DisplayVerse();
    }

    public bool HideRandomWord()
    {
        return verse.HideRandomWord();
    }

    public bool AllWordsHidden()
    {
        return verse.AllWordsHidden();
    }
}
