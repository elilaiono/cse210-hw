class Customer
{
    private List<Order> _orderHistory;
    public string Name { get; }
    public string PhoneNumber { get; }

    public Customer(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        _orderHistory = new List<Order>();
    }

    public void addToOrderHistory(Order order)
    {
        _orderHistory.Add(order);
    }

    public override string ToString()
    {
        return $"{Name} ({PhoneNumber})";
    }
}
