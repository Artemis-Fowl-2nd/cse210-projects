class Deck
{
    private List<Card> _decklist;

    public Card Draw()
    {
        Card a = _decklist[0];
        _decklist.RemoveAt(0);
        return a;

    }
}