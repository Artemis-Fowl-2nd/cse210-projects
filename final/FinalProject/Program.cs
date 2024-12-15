using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Select your cards to get points");
        Console.WriteLine("Good luck");

        Deck dek = new Deck();
        House House = new House();

        bool play = true;
        Hand playerHand = new Hand(7);
        Player aPlayer = new Player(name,playerHand);
        while(play)
        {
        while(! playerHand.IsOverHandLimit())
        {
            Card drawn = dek.Draw();
            playerHand.AddCard(drawn);
        }
        playerHand.Look();

        
        bool select = true; 

        while(select)
        {
            Console.WriteLine("Select a card (by position) or (S)ubmit your hand. Or, (Q)uit");
            string input = Console.ReadLine();
            if(input == "s")
            {

                int points = House.Judge(playerHand.Submit());
                
                aPlayer.AddPoints(points);
                select=false;
            }
            else if (input == "q")
            {
                play = false;
                select=false;
            }
            else
            {
                if (int.TryParse(input, out int parsedInput))
                    {
                    playerHand.Select(parsedInput);
                    }
                else
                    {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
            }
        }
        aPlayer.DisplayPoints();

        }

    }
}