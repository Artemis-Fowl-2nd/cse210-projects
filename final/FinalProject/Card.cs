class Card
{
    private int _rank;
    private string _suit;

    public Card(int rank, string suit)
    {
        _rank = rank;
        _suit = suit;
    }
    public int GetRank()
    {
        return _rank;
    }
    public void Display()
    {
        if (_rank == 1)
        {
            Console.Write("A");
        }
        else if( _rank ==11)
        {
            Console.Write("J");
        }
        else if(_rank ==12)
        {
            Console.Write("Q");
        }
        else if (_rank == 13)
        {
            Console.Write("K");
        }
        else
        {
            Console.Write(_rank);
        }
        Console.WriteLine($" {_suit}");
    }
}