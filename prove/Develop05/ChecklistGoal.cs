public class ChecklistGoal : Goal
{
    public int TotalCount { get; set; }
    public int CompletedCount { get; set; }

    public override string Type => "Checklist";

    public ChecklistGoal(string name, int value, int totalCount)
    {
        Name = name;
        Value = value;
        TotalCount = totalCount;
        CompletedCount = 0;
    }

    public override void Complete()
    {
        CompletedCount++;
        Console.WriteLine($"Goal '{Name}' completed {CompletedCount}/{TotalCount} times. You gained {Value} points!");

        if (CompletedCount >= TotalCount)
        {
            int bonusPoints = Value * TotalCount;
            Console.WriteLine($"Congratulations! You achieved the goal '{Name}' {TotalCount} times and earned a bonus of {bonusPoints} points!");
            Value += bonusPoints;
            TotalCount = 0;
            CompletedCount = 0;
        }
    }
}