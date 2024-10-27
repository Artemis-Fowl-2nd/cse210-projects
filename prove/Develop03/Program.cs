using System;

class Program
{
    static void Main(string[] args)
    {
        Reference a = new Reference("Proverbs","3",5,"6");

        List<Word> wordlist = new List<Word>
        {
            new Word("Trust",true),
            new Word("in",true),
            new Word("the",true),
            new Word("Lord",true),
            new Word("with",true),
            new Word("all",true),
            new Word("thine",true),
            new Word("heart;",true),
            new Word("and",true),
            new Word("lean",true),
            new Word("not",true),
            new Word("unto",true),
            new Word("thine",true),
            new Word("own",true),
            new Word("understanding.",true),
        };

        Scripture current = new Scripture(a,wordlist);
        
        string input = "";
        while (input != "quit")
        {
        Console.Clear();
        current.Display();
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type quit to finish");
        input = Console.ReadLine();
        current.Hide();
        
        }


    }
}