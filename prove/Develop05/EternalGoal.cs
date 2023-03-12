public class EternalGoal : Goal
{
    public override string Type => "Eternal";

    public EternalGoal(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public override void Complete()
    {
        Console.WriteLine($"You recorded progress on the eternal goal '{Name}'. You gained {Value} points!");
    }
}