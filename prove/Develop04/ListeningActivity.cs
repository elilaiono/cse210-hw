class ListeningActivity : Activity {
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int itemsCount;

    // Constructor calls the base class constructor
    public ListeningActivity() : base() {}

    // Method to run the listening activity
    public void Run() {
        DisplayStartingMessage("Listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        PauseWithCountdown(5);
        Console.WriteLine("Begin listing items:");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration) {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) {
                itemsCount++;
            }
        }
        Console.WriteLine($"You listed {itemsCount} items.");
        DisplayEndingMessage("Listening");
    }
}

