using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        string truth = "no";
        int count = 0;
        while (truth =="no")
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            count++;
            int numbered = int.Parse(guess);
            if (numbered == number)
            {
                truth = "yes";
            }
            else if (numbered > number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Higher");
            }


        }
        Console.WriteLine("You guesssed it!");
        Console.WriteLine($"You took {count} guesses!");
    }
}