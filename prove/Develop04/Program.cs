using System;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        while (choice != "4")
        {
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity bree = new BreathingActivity("Breathing Activity");
            int len = bree.StartBreathing();
            DateTime cur = DateTime.Now;
            DateTime endTime = cur.AddSeconds(len);
            while (DateTime.Now < endTime)
            {
                bree.Running();
            }
            bree.Conclude(len);
        }
        if (choice == "2")
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection Activity");
            int len = reflect.StartReflection();
            DateTime cur = DateTime.Now;
            DateTime endTime = cur.AddSeconds(len);
            while (DateTime.Now < endTime)
            {
                reflect.Running();
            }
            reflect.Conclude(len);
        }
        if (choice == "3")
        {
            ListingActivity lii = new ListingActivity("Listing Activity");
            int len = lii.StartListing();
            DateTime cur = DateTime.Now;
            List<string> listed = new List<string>();
            DateTime endTime = cur.AddSeconds(len);
            while (DateTime.Now < endTime)
            {
                
                string a = lii.Running();
                listed.Add(a);
            }
            lii.Conclude(len);
        }
        }
    }
}