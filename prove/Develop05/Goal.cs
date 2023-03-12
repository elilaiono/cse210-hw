// Base class 
public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public abstract string Type { get; }

    public virtual void Complete()
    {
        Console.WriteLine($"Goal '{Name}' completed. You gained {Value} points!");
    }
}