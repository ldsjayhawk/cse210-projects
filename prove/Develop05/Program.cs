using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        // int points = 0;  // likely need to delete
        // Console.WriteLine($"You have {points} points");
        GoalManager goalmanager = new GoalManager();
        goalmanager.Start();
    }

}