class Restaurant
{
    private string _name;
    private List<MenuItem> _menuItems;
    private List<Order> _orders;
    private Inventory _inventory;

    public Restaurant(string name)
    {
        _name = name;
        _menuItems = new List<MenuItem>();
        _orders = new List<Order>();
        _inventory = new Inventory();
    }

    public void AddMenuItem(MenuItem item)
    {
        _menuItems.Add(item);
    }

    public void RemoveMenuItem(MenuItem item)
    {
        _menuItems.Remove(item);
    }

    

    public void createOrder(Customer customer, List<MenuItem> items)
    {
    int orderNumber = _orders.Count + 1;
    Order order = new Order(orderNumber, customer, items);
    _orders.Add(order);
    customer.addToOrderHistory(order);
    Console.WriteLine("Order created successfully.");
    }


    public void PrintMenu()
    {
        Console.WriteLine($"Menu for {_name}:");
        foreach (var item in _menuItems)
        {
            Console.WriteLine($"{item.ItemNumber}: {item.Name} - ${item.Price}");
        }
    }

    public void PrintInventory()
    {
    Console.WriteLine($"Inventory for {_name}:");
    foreach (var item in _inventory.Items)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to {_name}!");
    }

    public void DisplayGoodbyeMessage()
    {
    Console.WriteLine("Thank you for dining with us. Goodbye!");
    }
   

    public void DisplayMenu()
    {
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1. Add item to order");
    Console.WriteLine("2. Remove item from order");
    Console.WriteLine("3. View current order");
    Console.WriteLine("4. Place order and exit");
    }   


}
