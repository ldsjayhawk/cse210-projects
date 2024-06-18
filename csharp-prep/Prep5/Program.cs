using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
    static void DisplayWelcome()
    // Displays the message, "Welcome to the Program!"
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    // Asks for and returns the user's name (as a string)
    {    
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    // Asks for and returns the user's favorite number (as an integer)
    {
        Console.WriteLine("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static double SquareNumber(int number)
    // Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        double squaredNumber = Math.Pow(number,2);
        return squaredNumber;   
    }
    
    static void DisplayResult(string name, double number)
    // Accepts the user's name and the squared number and displays them.
    {
        Console.WriteLine($"{name} {number}");
    }
}