class Deck
{
    
    private List<Card> _decklist;

    public Card Draw()
    {
        Random rnd = new Random();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string suit = suits[rnd.Next(0, suits.Length)];
        Card a = new Card(rnd.Next(1, 14),suit);
        
        return a;

    }

    public Deck()
    {
        
    }

    
}