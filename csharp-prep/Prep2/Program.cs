using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePct = Console.ReadLine();

        int grade = int.Parse(gradePct);
        string letter = "";
        string plusMinus = "";

        if (grade > 93 || grade < 60)
        {
            plusMinus = "";
        }
        else if (grade % 10 >= 7)
        {
            plusMinus = "+";
        }
        else if (grade % 10 <= 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }


        if (grade >= 70)
        {
            Console.Write ($"Your grade is {letter}{plusMinus}. You passed the class!");
        }
        else
        {
            Console.Write ($"Your grade is {letter}{plusMinus}. Please try again.  You can do it!");
        }

    }
}