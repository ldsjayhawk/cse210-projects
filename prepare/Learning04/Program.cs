using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        MathAssignment assignment1 = new MathAssignment("Samuel Bennett","Multiplication","1.1", "1-5");
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Samuel Bennett", "Essay","When Dinosaurs Roamed the Earth");
        Console.WriteLine(assignment2.GetWritingInformation());
        Console.WriteLine();

    }
}