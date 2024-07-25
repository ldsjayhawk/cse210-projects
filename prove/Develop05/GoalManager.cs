using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Transactions;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;  // same as points I think
    private int points;

    private string file;

    public GoalManager()
    {
        points = 0;
        _score = 0;
        file = "goals.txt";
    }


    public void Start()
    {
        string choice = "";
        Console.Clear();
        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Please select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                AddGoal();
            }

            else if (choice == "2")
            {
                ListGoals();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Fix this");
                // LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice == "6")
            {
                Console.WriteLine("Thank you.  Goodbye!");
            }
            else
                Console.WriteLine("Please select option 1-6.");
        Console.WriteLine("Press enter to return to menu.");
        string x = Console.ReadLine();
        Console.Clear();
        }
        while (choice != "6");
    }

    public void AddGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goals");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();


        Console.WriteLine($"What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Please provide a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine($"What is the amount of points associated with this goal? ");
        string pointTotal = Console.ReadLine();
        points = int.Parse(pointTotal);

        if (goalChoice == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }

        else if (goalChoice == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }

        else if (goalChoice == "3")
        {
            int target = 0;
            int bonus = 0;

            Console.Write("Please enter the number of times you would like to perform this goal: ");
            string targetstr = Console.ReadLine();
            target = int.Parse(targetstr);

            Console.WriteLine("Please enter the bonus value: ");
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }

        else
            Console.WriteLine("Please select goal 1-3.");

    }

    public void ListGoals()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
    }


    public void RecordEvent()
    {
        ListGoals();
        Console.Write($"Select which goal you would like to record: ");
        string recordGoal = Console.ReadLine();
        int choice = int.Parse(recordGoal);

        Console.WriteLine(choice);
        if (_goals[choice].IsComplete() == true)
            Console.WriteLine("Goal has already been completed.");
        else
        {
            _score += _goals[choice].RecordEvent();
            ListGoals();
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine("Score|{_score}");
            foreach (Goal goal in _goals)
                sw.WriteLine(goal.GetStringRepresentation());
        }
    }

    // public void LoadGoals()
    // {
    //     _goals.Clear();
    //     string[] lines = File.ReadAllLines(file);
    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("|");

    //         SimpleGoal simple = new SimpleGoal(name, description, points, isComplete);
    //         _goals.Add(simple);

    //         EternalGoal eternal = new EternalGoal(name, description, points);
    //         _goals.Add(eternal);

    //         ChecklistGoal checklist = new ChecklistGoal(name, description, points, IsComplete, score, target, bonus);
    //         _goals.Add(checklist);
    //     }
    //  }
}