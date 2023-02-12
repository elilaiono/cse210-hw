public class ScriptureCollection
{
    // use private variables
    private Scripture[] scriptures;
    private Random random = new Random();

    public ScriptureCollection(Scripture[] scriptures)
    {
        this.scriptures = scriptures;
    }

    public void Run()
    {
        Console.Clear();

        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine(scripture.Reference + " " + scripture.Text);
        }

        Console.WriteLine("Press enter to begin.");
        string input = Console.ReadLine();
        if (input == "quit")
        {
            return;
        }

        while (true)
        {
            int index = random.Next(scriptures.Length);
            Scripture scripture = scriptures[index];
            int wordIndex = random.Next(scripture.HiddenWords.Length);
            scripture.HideWord(wordIndex);

            Console.Clear();
            foreach (Scripture s in scriptures)
            {
                Console.Write(s.Reference + " ");
                foreach (string word in s.HiddenWords)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            if (scripture.IsComplete())
            {
                Console.WriteLine("Press enter to quit.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Press enter to continue or type quit.");
            input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
        }
    }
}