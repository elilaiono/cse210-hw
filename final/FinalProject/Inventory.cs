class Inventory
{
    private Dictionary<string, int> _items;

    public Inventory()
    {
        _items = new Dictionary<string, int>();
    }

    public Dictionary<string, int> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    public void AddItem(string itemNumber, int quantity)
    {
        if (_items.ContainsKey(itemNumber))
        {
            _items[itemNumber] += quantity;
        }
        else
        {
            _items[itemNumber] = quantity;
        }
    }

    public void RemoveItem(string itemNumber, int quantity)
    {
        if (_items.ContainsKey(itemNumber))
        {
            if (_items[itemNumber] >= quantity)
            {
                _items[itemNumber] -= quantity;
                if (_items[itemNumber] == 0)
                {
                    _items.Remove(itemNumber);
                }
            }
            else
            {
                throw new ArgumentException("Insufficient quantity in inventory.");
            }
        }
        else
        {
            throw new ArgumentException("Item not found in inventory.");
        }
    }

    public bool ContainsItem(string itemNumber)
    {
        return _items.ContainsKey(itemNumber);
    }

    public int GetItemQuantity(string itemNumber)
    {
        if (_items.ContainsKey(itemNumber))
        {
            return _items[itemNumber];
        }
        else
        {
            throw new ArgumentException("Item not found in inventory.");
        }
    }
}
