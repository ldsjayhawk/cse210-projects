using System;
using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
        Swimming swim = new Swimming("Swimming","01 Jan 2024", 60, 60);
        Running run = new Running("Running","03 Jan 2024", 45, 3);
        Cycling cycle = new Cycling("Cycling","05 Jan 2024", 60, 15); 

        Console.Clear();
        run.DisplayActivity();
        swim.DisplayActivity();
        cycle.DisplayActivity();
        Console.WriteLine();
    }
}