class House
{   
    private int _time;
    public House()
    {
        _time = 10;
    }
    public int Judge(List<Card> a)
    {
        int points = 0;
        foreach(Card target in a)
        {
            points += target.GetRank();
        }
        return points;
    }
}