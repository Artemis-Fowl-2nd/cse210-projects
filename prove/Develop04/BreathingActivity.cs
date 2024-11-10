public class BreathingActivity : BaseActivity
{
    private string _breathDescription;
    private List<string> _list1;
    public BreathingActivity(string type): 
    base(type)
    {
        _breathDescription ="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.WriteLine(_breathDescription);
        
    }

    public void Running()
    {
        Console.WriteLine("Breath in");
        Pause();
        Console.WriteLine("3");
        Pause();
        Console.WriteLine("2");
        Pause();
        Console.WriteLine("1");
        Console.WriteLine("Breath out");
        Pause();
        Console.WriteLine("3");
        Pause();
        Console.WriteLine("2");
        Pause();
        Console.WriteLine("1");
    }

    public int StartBreathing()
    {
        int turn = GenericDisplay("Breathing Activity");

        return turn;
    }
    
}