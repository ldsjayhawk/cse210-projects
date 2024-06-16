using System;

class Program
{
    static void Main(string[] args)
    {
        //variables
        List<int> numbers = new List<int>();
        int userNumber = 1;
        int runningTotal = 0;
        int count = 0;
        float average = 0;
        int largest = -1;
        int smallestPositive = 999;

        //add numbers to list until user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string selectedNumber = Console.ReadLine();
            userNumber = int.Parse(selectedNumber);
            if (userNumber != 0)
                numbers.Add(userNumber);
        }
        
        //for each number in the list: 
        //count (for average)
        //add (for running total)
        //check for largest
        for (int i = 0; i < numbers.Count; i++)
        {
            count += 1;
            int number = i;
            runningTotal += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number > 0 && number < smallestPositive)
            {   
                smallestPositive = number;
            }
            Console.WriteLine($"{number}");
        }
    
        //compute average & print running total, average & largest number
        average = runningTotal / count;
        Console.WriteLine($"The total of the numbers is {runningTotal}.");
        Console.WriteLine($"The average of the numbers is {average}.");
        Console.WriteLine($"The largest number is {largest}.");
        Console.WriteLine($"The smallest positive number is {smallestPositive}.");
    }
}