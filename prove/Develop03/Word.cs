 class Word
{
    private string _word;
    private bool _shown;
    public Word(string a, bool b)
    {
        _word = a;
        _shown = b;
    }
   
    public void Dis()
    {if (_shown)
    {
        Console.Write($"{_word} ");
    }
    else
    {
        Console.Write("____ ");
    }
    }
    public bool GetShown()
    {
        return _shown;
    }
    public int Change()
    {
        if (_shown)
        { 
            _shown = false;

            return 1;
        }
        else
        {
            _shown = false;
            return 0;
        }

    }
}