class Hand()
{
    private List<Card> _cardsInHand;

    private List<Card> _selectedCards;
    private int _handSize;

    public void Select(int a)
    {
        _selectedCards.Add(_cardsInHand[a]);
    }

    public void Discard(Card a)
    {
        _cardsInHand.Remove(a);
        //Draw();
    }

    public List<Card> Submit()
    {
        return _selectedCards;
        //foreach( Card a in _selectedCards)
        {
          //  Discard(a);
        }
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
}