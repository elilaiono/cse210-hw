public class SimpleGoal : Goal
{
    public override string Type => "Simple";

    public SimpleGoal(string name, int value)
    {
        Name = name;
        Value = value;
    }
}