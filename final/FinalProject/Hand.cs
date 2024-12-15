class Hand
{
    private List<Card> _cardsInHand;

    private List<Card> _selectedCards;
    private int _handSize;
    
    public Hand(int handSize)
    {
        _cardsInHand = new List<Card>();
        _selectedCards = new List<Card>();
        _handSize = handSize;
    }

    

    public void Select(int a)
    {   
        if(_selectedCards.Count()<5)
        {
        _selectedCards.Add(_cardsInHand[a]);
        }
        else
        {
            Console.WriteLine("You cant select that many cards");
        }
    }

    public void Discard(Card discard)
    {
        _cardsInHand.Remove(discard);
    }

    public void AddCard(Card Added)
    {
        _cardsInHand.Add(Added);
    }

    public List<Card> Submit()
    {
        List<Card> a = _selectedCards;
        _selectedCards.Clear();
        return a;
    }

    public bool IsOverHandLimit()
    {
        if(_cardsInHand.Count>_handSize)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Look()
    {
    foreach(Card look in _cardsInHand)
        {
            look.Display();
        }
    }
}