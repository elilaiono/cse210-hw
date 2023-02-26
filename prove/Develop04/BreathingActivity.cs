// Breathing activity class
class BreathingActivity : Activity {
    // Constructor calls the base class constructor
    public BreathingActivity() : base() {}

    // Method to run the breathing activity
    public void Run() {
        DisplayStartingMessage("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < duration; i += 2) {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(2);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(2);
        }
        DisplayEndingMessage("Breathing");
    }
}