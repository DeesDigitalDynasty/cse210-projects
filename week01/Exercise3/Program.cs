using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup the random number generator
        Random randomGenerator = new Random();

        //Generate a random number btw 1 - 100
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        //Loop that keeps going if the guess does not match the magic num
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);

            // If statement to determine if the user needs to guess higher or lower
            if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            }
        }

       
    }
}