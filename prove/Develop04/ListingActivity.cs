public class ListingActivity:BaseActivity
{
    private List<string> _list1;
    private string _listDescription;

    public ListingActivity(string type):
    base(type)
    {
        _listDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Console.WriteLine(_listDescription);
        _list1 = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public int StartListing()
    {
        int turn = GenericDisplay("Listing Activity");
        var random = new Random();
        int index = random.Next(_list1.Count);
        Console.WriteLine(_list1[index]);
        Pause();
        Pause();
        Pause();
        return turn;
    }
    public string Running()
    {
        string input = Console.ReadLine();
        return input;
    }
}