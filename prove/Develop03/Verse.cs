public class Verse
{
    private string text;
    private bool[] hiddenWords;

    public Verse(string text)
    {
        this.text = text;
        hiddenWords = new bool[text.Split(' ').Length];
    }

    public void DisplayVerse()
    {
        for (int i = 0; i < text.Split(' ').Length; i++)
        {
            if (hiddenWords[i])
                Console.Write("***** ");
            else
                Console.Write($"{text.Split(' ')[i]} ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        int wordIndex = GetRandomHiddenWordIndex();
        if (wordIndex != -1)
        {
            hiddenWords[wordIndex] = true;
            return true;
        }
        return false;
    }

    private int GetRandomHiddenWordIndex()
    {
        int[] hiddenIndices = GetHiddenWordIndices();
        if (hiddenIndices.Length > 0)
        {
            int randomIndex = new Random().Next(0, hiddenIndices.Length);
            return hiddenIndices[randomIndex];
        }
        return -1;
    }

    private int[] GetHiddenWordIndices()
    {
        List<int> hiddenIndices = new List<int>();
        for (int i = 0; i < hiddenWords.Length; i++)
        {
            if (!hiddenWords[i])
                hiddenIndices.Add(i);
        }
        return hiddenIndices.ToArray();
    }

    public bool AllWordsHidden()
    {
        return !hiddenWords.Contains(false);
    }
}
