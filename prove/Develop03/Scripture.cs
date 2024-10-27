using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference a, List<Word> b)
    {
        _reference = a;
        _words = b;
    }

    public void Write(List<Word> a, Reference b)
   {
    
   }
    public void Display()
    {
        _reference.Display();
        foreach(Word a in _words)
        {
            a.Dis();
        }
    }

    public void Hide()
    {

        int count = 0;
        while (count <3)
        {
        Random random = new Random();
        int target = random.Next(_words.Count);
        count = count + _words[target].Change();
        
        int abort = 0;
        foreach (Word a in _words)
        {
            
            if (a.GetShown())
            {
                abort = abort +1;
            }
        }
        if (abort == 0)
        {
            count = 3;
        }
            
        }


    }
    
}