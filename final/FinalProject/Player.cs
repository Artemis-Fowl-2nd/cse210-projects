class Player()
{
    private string _name;
    private int _points;
    private Hand _playerHand;
    public Player(string name, Hand a):this()
    {
        _name = name;
        _points = 0;
        _playerHand = a;
    }

    public void AddPoints(int add)    
    {
        _points = _points + add + 1;
    }    

    public void DisplayPoints()
    {
        Console.WriteLine($"Player {_name} has {_points} points");
    }
    

}