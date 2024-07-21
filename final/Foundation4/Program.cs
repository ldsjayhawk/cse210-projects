using System;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim = new Swimming("01 Jan 2024", 60, 20);
        Running run = new Running("03 Jan 2024", 30, 3);
        Cycling cycle = new Cycling("05 Jan 2024", 60, 15); 

        run.DisplayActivity();
    }
}