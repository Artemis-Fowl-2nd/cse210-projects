using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        string go = null;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (go != "0")
        {
        Console.WriteLine("Enter number: ");
        string input = Console.ReadLine();
        go = input;
        int intput = int.Parse(input);
        numbers.Add(intput);
        }
        int summ = numbers.Sum();
        float mean = summ/numbers.Count();
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {summ}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {max}");
    }
}