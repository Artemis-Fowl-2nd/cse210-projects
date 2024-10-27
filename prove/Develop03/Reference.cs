class Reference
{
    private string _book;
    private string _chapter;
    private int _ref;
    private string _ref2;

    public Reference()
    {
        _book = "";
        _chapter = "";
        _ref = 0;
    }

    public Reference(string a, string b, int c)
    {
        _book = a;
        _chapter = b;
        _ref = c;
        _ref2="";
    }

    public Reference(string a, string b, int c, string d)
    {
        _book = a;
        _chapter = b;
        _ref = c;
        _ref2 = d;
    }

    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_ref}-{_ref2} ");
    }
    
}