using System;

class Program
{
    static void Main(string[] args)
    {
        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            return input;
        }
        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string word = Console.ReadLine();
            float input = int.Parse(word);
            return input;
        }

        static float SquareNumber(float input)
        {
            return input * input;
        }

        static void DisplayResult(float num, string name)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {num}.");
        }
        DisplayWelcome();
        string name = PromptUserName();
        float number = PromptUserNumber();
        float mathed = SquareNumber(number);
        DisplayResult(mathed,name);

        
    }
}