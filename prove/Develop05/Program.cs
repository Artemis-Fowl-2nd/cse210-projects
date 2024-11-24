using System;
using System.Data;
using System.IO; 

class Program
{
    
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;
        bool run = true;
        while(run)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            string input = Console.ReadLine();

            if(input == "1")
            {
                Console.WriteLine("What type of goal woul you like to create? ");
                Console.WriteLine("1 Simple Goal");
                Console.WriteLine("2 Eternal Goal");
                Console.WriteLine("3 ChecklistGoal");
                string goalType = Console.ReadLine();
                if(goalType == "1")
                {
                    var simpleGoal = new SimpleGoal("", "", 0, false);
                    simpleGoal.Create();
                    goals.Add(simpleGoal);
                }
                if(goalType == "2")
                {
                    var eternalGoal = new EternalGoal("", "", 0);
                    eternalGoal.Create();
                    goals.Add(eternalGoal);
                }
                if (goalType == "3")
                {
                    var checklistGoal = new ChecklistGoal("", "", 0,0,0,0);
                    checklistGoal.Create();
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }

            if(input == "2")
            {
                foreach (var goal in goals)
                {
                    goal.Display();
                }
            }

            if(input == "3")
            {
                Console.WriteLine("Where do you want to save?");
                string filename = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (var goal in goals)
                        {
                            if (goal is SimpleGoal simpleGoal)
                            {
                                writer.WriteLine(simpleGoal.Save());
                            }
                            else if (goal is EternalGoal eternal)
                            {
                                writer.WriteLine(eternal.Save());
                            }
                            else if (goal is ChecklistGoal check)
                            {
                                writer.WriteLine(check.Save());
                            }
                            else{Console.WriteLine("oops");}
                        }
                    }
            }


            if(input == "4")
            {
                Console.WriteLine("Where do you want to load from?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int reward = int.Parse(parts[3]);
                    if(type == "SimpleGoal")
                    {
                        bool complete = bool.Parse(parts[4]);
                        var simpleGoal = new SimpleGoal(name, description, reward, complete);
                        goals.Add(simpleGoal);
                    }
                    if (type == "EternalGoal")
                    {
                        var eternal = new EternalGoal(name,description,reward);
                        goals.Add(eternal);
                    }
                    if (type == "ChecklistGoal")
                    {
                        int bonus = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int times = int.Parse(parts[6]);
                        var check = new ChecklistGoal(name,description,reward,bonus,target,times);
                        goals.Add(check);
                    }
                }
            }
            if(input == "5")
            {
                Console.WriteLine("What number goal have you completed?");
                int win = int.Parse(Console.ReadLine());
                int injection = goals[win].Complete();
                points += injection;
            }
            if(input =="6")
            {
                run = false;
            }
            Console.WriteLine($"You have{points} points");
        }
    }
}