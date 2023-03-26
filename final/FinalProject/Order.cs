class Order
{
    private int _orderNumber;
    private Customer _customer;
    private List<MenuItem> _items;
    private DateTime _dateTime;

    public Order(int orderNumber, Customer customer, List<MenuItem> items)
    {
        _orderNumber = orderNumber;
        _customer = customer;
        _items = items;
        _dateTime = DateTime.Now;
    }

    public void AddItem(MenuItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(MenuItem item)
    {
        _items.Remove(item);
    }

    public decimal GetTotal()
    {
        decimal total = 0;
        foreach (var item in _items)
        {
            total += item.Price;
        }
        return total;
    }

    public void Print()
    {
        Console.WriteLine("Order:");
        Console.WriteLine($"Customer: {_customer.Name}");
        foreach (var item in _items)
        {
            Console.WriteLine($"{item.ItemNumber}: {item.Name} - ${item.Price}");
        }
        Console.WriteLine($"Total: ${GetTotal()}");
    }
}
