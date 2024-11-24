public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointsReward;

    
    public abstract void Create();
    
    public abstract int Complete();

    public abstract void Display();
    
}