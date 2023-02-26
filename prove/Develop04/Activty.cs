// BASE CLASS
class Activity {
    protected int duration; // Duration of the activity in seconds

    // Constructor for the activity, prompts the user for the duration
    public Activity() {
        Console.Write("Enter duration of activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    // Method to display the starting message
    protected virtual void DisplayStartingMessage(string name, string description) {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Get ready to begin in:");
        for (int i = 3; i >= 1; i--) {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");
    }

    // Method to display the ending message
    protected virtual void DisplayEndingMessage(string name) {
        Console.WriteLine($"You did a great job on the {name} activity!");
        Console.WriteLine($"Time taken: {duration} seconds");
        Console.WriteLine("Well done! Press any key to continue.");
        Console.ReadKey();
    }

    // Method to display a spinner animation while pausing
    protected void PauseWithSpinner(int seconds) {
        int totalPause = 0;
        Console.Write("Processing");
        while (totalPause < seconds * 1000) {
            Console.Write(".");
            Thread.Sleep(500);
            totalPause += 500;
        }
        Console.WriteLine();
    }

    // Method to display a countdown animation while pausing
    protected void PauseWithCountdown(int seconds) {
        Console.Write($"Time remaining: {seconds} seconds");
        for (int i = seconds; i >= 1; i--) {
            Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop);
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}



