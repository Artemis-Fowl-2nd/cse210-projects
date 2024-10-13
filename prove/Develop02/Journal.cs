using System.IO; 
public class Journal
{
    
    public List<Entry> _entries;

    public  Journal()
    {
        _entries = new List<Entry>();
    }
    public void Write()
    {

        string prom = Prompt.Display();
        string input = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry entry = new Entry();
        entry._prompt = prom;
        entry._date=date;
        entry._entry=input;
        _entries.Add(entry);
    }

    public void Save()
    {
        Console.WriteLine("What is the file name?");
        string sname = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(sname))
        {
            foreach (Entry i in _entries)
            {
            outputFile.WriteLine($"{i._prompt}^{i._date}^{i._entry}");
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the file name?");
        string lname = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(lname);
        foreach (string line in lines)
        {
            string[] parts = line.Split("^");
            Entry entry = new Entry();
            entry._prompt = parts[0];
            entry._date=parts[1];
            entry._entry=parts[2];
            _entries.Add(entry);
        }

    }

    public void Display()
    {
        foreach (Entry i in _entries)
        {
        Console.WriteLine($"Date: {i._date} - Prompt: {i._prompt}");
        Console.WriteLine(i._entry);
        Console.WriteLine("");

        }
    }

    public void Discard()
        {
            _entries.RemoveAt(_entries.Count - 1);
        }
    
}