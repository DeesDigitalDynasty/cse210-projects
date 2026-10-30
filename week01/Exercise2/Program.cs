using System;

class Program
{
    static void Main(string[] args)
    {
        // Request grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        // Create a string variable to hold the grade
        string letter = "";

        //Determine the letter grade
        if(percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Print grade letter once
        Console.WriteLine($"Your grade is: {letter}");

        //Check if they passed
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep working hard for next time, I believe in you!");
        }
    }
}