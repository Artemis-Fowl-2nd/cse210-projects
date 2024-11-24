public class ChecklistGoal : Goal
{
    private int _pointBonus;
    private int _target;
    private int _timesRun;
    public ChecklistGoal(string name, string description, int pointsReward, int pointBonus, int target,int times)
    {
        _name = name;
        _description = description;
        _pointsReward = pointsReward;
        _pointBonus = pointBonus;
        _target = target;
        _timesRun = times;

    }
    public override void Create()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        _description = Console.ReadLine();

        Console.Write("Enter points reward: ");
        _pointsReward = int.Parse(Console.ReadLine());

        Console.Write("Enter completion reward: ");
        _pointBonus = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be completed for a reward? ");
        _target = int.Parse(Console.ReadLine());

    }
    public override int Complete()
    {
        _timesRun += 1;
        int a = 0;
        if(_target == _timesRun)
        {
            a = _pointBonus;
        }
        int b = _pointsReward + a;
        return b;
    }
    public override void Display()
    {   
        if(_timesRun >= _target)
        {
            Console.Write("[X]");
        }
        else
        {
            Console.Write("[ ]");
        }
        
        Console.WriteLine($"{_name} ({_description}) - currently completed: {_timesRun}/{_target}");
    }

    public string Save()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_pointsReward}|{_pointBonus}|{_target}|{_timesRun}";
    }
}