
public class Scripture
{
    private string reference;
    private string text;
    private string[] hiddenWords;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        hiddenWords = text.Split(' ');
    }

    public Scripture(string reference, string text, string[] hiddenWords)
    {
        this.reference = reference;
        this.text = text;
        this.hiddenWords = hiddenWords;
    }

    public string Reference
    {
        get { return reference; }
    }

    public string Text
    {
        get { return text; }
    }

    public string[] HiddenWords
    {
        get { return hiddenWords; }
    }

    public void HideWord(int index)
    {
        hiddenWords[index] = new string('_', hiddenWords[index].Length);
    }

    public bool IsComplete()
    {
        foreach (string word in hiddenWords)
        {
            if (word != new string('_', word.Length))
            {
                return false;
            }
        }
        return true;
    }
}