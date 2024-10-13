using System;
public class ProgramJournal
{

    
    public static string DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Discard latest entry");
        Console.WriteLine("What would you like to do? ");
        string input = Console.ReadLine();
        return input;
    }
    static void Main()
    {
        Journal current = new Journal();
        string input;
        Console.WriteLine("Welcome to the journal program!");

        do
        {
            input = DisplayMenu();
            if (input == "1")
            {
                current.Write();
            }
            if (input == "2")
            {
                current.Display();
            }
            if (input == "3")
            {
                current.Load();
            }
            if (input == "4")
            {
                current.Save();
            }
            if (input == "6")
            {
                current.Discard();
            }
        } while (input != "5");
    }
}

