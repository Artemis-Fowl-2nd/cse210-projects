public class BaseActivity
{
    private string _type;

    public BaseActivity(string a)
    {
        _type = a;
    }
    public int GenericDisplay(string a)
    {
        Console.WriteLine(a);
        
        Console.Write("What is the desired activity length? ");
        int sec = Console.Read();
        Console.WriteLine("Prepare to begin");
        Pause();
        Pause();
        Pause();
        return sec;
    }
    public void Pause()
    {
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
        Console.Write(".");
        Thread.Sleep(250);
    }

    public void Conclude(int time)
    {
        Console.WriteLine("Good Job!");
        Pause();
        Console.WriteLine($"You completed {time} seconds of activity {_type}");
    }
}