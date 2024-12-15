class Deck
{
    
    private List<Card> _decklist;
    Random rnd = new Random();

    public Card Draw()
    {
        
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string suit = suits[rnd.Next(0, suits.Length)];
        int rank = rnd.Next(1, 14);
        Card a = new Card(rank,suit);
        return a;
    }

    public Deck()
    {
        
    }

    
}