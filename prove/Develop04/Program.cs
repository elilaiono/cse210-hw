
class Program {
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListeningActivity listeningActivity = new ListeningActivity();

        Console.WriteLine("Welcome to the Mindfulness App");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflection activity");
            Console.WriteLine("3. Listening activity");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Starting breathing activity...");
                breathingActivity.Run();
                
            }
            else if (input == "2")
            {
                Console.WriteLine("Starting reflection activity...");
                reflectionActivity.Run();
            }
            else if (input == "3")
            {
                Console.WriteLine("Starting listening activity...");
                listeningActivity.Run();
            }
            else if (input == "4")
            {
                Console.WriteLine("Exiting...");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
