class MenuItem
{
    public string ItemNumber { get; }
    public string Name { get; }
    public decimal Price { get; }

    public MenuItem(string itemNumber, string name, decimal price)
    {
        ItemNumber = itemNumber;
        Name = name;
        Price = price;
    }
}
