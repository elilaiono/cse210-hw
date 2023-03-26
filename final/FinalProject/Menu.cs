class Menu
{
    private Dictionary<string, MenuItem> items;

    public Menu()
    {
        items = new Dictionary<string, MenuItem>();
    }

    public void AddMenuItem(MenuItem item)
    {
        items[item.ItemNumber] = item;
    }

    public void RemoveMenuItem(string itemNumber)
    {
        if (items.ContainsKey(itemNumber))
        {
            items.Remove(itemNumber);
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("--------------------");
        foreach (var item in items.Values)
        {
            Console.WriteLine($"{item.ItemNumber}: {item.Name} (${item.Price})");
        }
        Console.WriteLine("--------------------");
    }

    public MenuItem GetMenuItem(string itemNumber)
    {
        if (items.ContainsKey(itemNumber))
        {
            return items[itemNumber];
        }
        else
        {
            return null;
        }
    }
}
