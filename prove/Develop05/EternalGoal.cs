public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsReward)
    {
        _name = name;
        _description = description;
        _pointsReward = pointsReward;
    }
    public override void Create()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        _description = Console.ReadLine();

        Console.Write("Enter points reward: ");
        _pointsReward = int.Parse(Console.ReadLine());

    }
    public override int Complete()
    {
        return _pointsReward;
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public string Save()
    {
        return $"EternalGoal|{_name}|{_description}|{_pointsReward}";
    }
}