class Card()
{
    private int _rank;
    private string _suit;

    private int _id;

    public void Display()
    {
        if (_rank == 1)
        {
            Console.WriteLine("A");
        }
        else if( _rank ==11)
        {
            Console.WriteLine("J");
        }
        else if(_rank ==12)
        {
            Console.WriteLine("Q");
        }
        else if (_rank == 13)
        {
            Console.WriteLine("K");
        }
        else
        {
            Console.WriteLine(_rank);
        }
        Console.WriteLine(_suit);
    }
}