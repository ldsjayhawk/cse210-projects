using System;

class Program
{
    static void Main(string[] args)
    {

        //Initialize variables
        int numberGuess = 0;
        int guess = 0;
     
        //Generate a random number between 1 and 100
        //Random randomNumber = new Random();
        //int magicNumber = randomNumber.Next(1, 101);

        int magicNumber = 51;
        
        while (guess != magicNumber)
        {
            numberGuess++;
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
        
            if (guess > magicNumber)
            {
                Console.WriteLine ($"Lower - Your guess was {guess}. Guess #{numberGuess}");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine ($"Higher - Your guess was {guess}. Guess #{numberGuess}");
            }

            else
            {
                Console.Write ($"You guessed it in {numberGuess} tries!");
            }
        }
    }
}