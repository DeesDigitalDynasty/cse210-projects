using System;

class Program
{
    static void Main(string[] args)
    {
        // Request the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Request the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print the final sentence
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}