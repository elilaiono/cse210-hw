class Program
{
    static void Main(string[] args)
    {
        // Initialize Restaurant object
        Restaurant restaurant = new Restaurant("Eli's Restaurant");

        // Display welcome message
        restaurant.DisplayWelcomeMessage();

        // Loop to handle user input
        bool exit = false;
        while (!exit)
        {
            // Display menu and get user input
            restaurant.DisplayMenu();
            string userInput = Console.ReadLine();

            // Process user input
            switch (userInput)
            {
                case "1":
                    restaurant.AddToOrder();
                    break;
                case "2":
                    restaurant.RemoveFromOrder();
                    break;
                case "3":
                    restaurant.ViewOrder();
                    break;
                case "4":
                    restaurant.PlaceOrder();
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        // Display goodbye message
        restaurant.DisplayGoodbyeMessage();
    }
}
