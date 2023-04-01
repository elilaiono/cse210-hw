using System;
using System.Collections.Generic;
using System.Linq;


class Restaurant
{
    private string _name;
    private List<MenuItem> _menu;
    private Order _order;
    private List<Order> _orders;
    private Inventory _inventory;

public Restaurant(string name)
{
    _name = name;
    _menu = new List<MenuItem>();
    _orders = new List<Order>();
    _inventory = new Inventory();
    _order = new Order(1, new Customer("John Doe"),  new MenuItem(2, "Pizza", 16.00m));
}


    public void AddMenuItem(MenuItem item)
    {
        _menu.Add(item);
    }

    public void RemoveMenuItem(MenuItem item)
    {
        _menu.Remove(item);
    }

    public void AddToOrder()
    {
        Console.WriteLine("Please enter the name of the item you would like to add to the order:");
        string itemName = Console.ReadLine();

        if (_menu.Any(item => item.Name == itemName))
        {
            Console.WriteLine("Please enter the quantity:");
            int quantity = int.Parse(Console.ReadLine());

            try
            {
                if (_order == null)
                {
                    _order = new Order(1, new Customer("John Doe"),  new MenuItem(2, "Pizza", 16.00m));
                }

                _order.AddItem(_menu.Find(item => item.Name == itemName), quantity);
                Console.WriteLine($"{quantity} {itemName} added to the order.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Item not found on the menu.");
        }
    }

    public void RemoveFromOrder()
    {
        Console.WriteLine("Please enter the name of the item you would like to remove from the order:");
        string itemName = Console.ReadLine();

        if (_order != null && _order.ContainsItem(itemName))
        {
            Console.WriteLine("Please enter the quantity:");
            int quantity = int.Parse(Console.ReadLine());

            try
            {
                _order.RemoveItem(itemName, quantity);
                Console.WriteLine($"{quantity} {itemName} removed from the order.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Item not found in the order.");
        }
    }

    public void ViewOrder()
    {
        if (_order != null && _order.Items.Count > 0)
        {
            Console.WriteLine("Current order:");
            Console.WriteLine(_order);
        }
        else
        {
            Console.WriteLine("No items in the order.");
        }
    }

    public void PlaceOrder()
    {
        if (_order != null && _order.Items.Count > 0)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your phone number:");
            string phoneNumber = Console.ReadLine();

            Customer customer = new Customer(name, phoneNumber);

            try
            {
                _order.SetCustomer(customer);
                _order.SetStatus(OrderStatus.Pending);
                _orders.Add(_order);
                customer.AddToOrderHistory(_order);
                Console.WriteLine("Order placed successfully.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            _order = new Order();
        }
        else
        {
            Console.WriteLine("No items in the order.");
        }
    }

    public void PrintMenu()
    {
        Console.WriteLine($"Menu for {_name}:");
        foreach (var item in _menu)
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
