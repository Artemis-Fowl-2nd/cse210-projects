public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int pointsReward, bool isComplete)
    {
        _name = name;
        _description = description;
        _pointsReward = pointsReward;
        _isComplete = isComplete;
    }

    
    public override void Create()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        _description = Console.ReadLine();

        Console.Write("Enter points reward: ");
        _pointsReward = int.Parse(Console.ReadLine());

        _isComplete = false;
    }
    public override int Complete()
    {
        if(_isComplete == false)
        {
            _isComplete = true;
            return _pointsReward;
        }
        else{return 0;}
    }

    public override void Display()
    {   
        if(_isComplete)
        {
            Console.Write("[X]");
        }
        else
        {
            Console.Write("[ ]");
        }
        Console.WriteLine($"{_name}, ({_description}) ");
    }
    public string Save()
    {
        return $"SimpleGoal|{_name}|{_description}|{_pointsReward}|{_isComplete}";
    }
}