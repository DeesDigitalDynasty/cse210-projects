using System;


// EXCEEDING REQUIREMENTS NOTE:
// This program includes a Scripture Library feature.
// The program loads a collection of multiple scriptures and selects one at random each time the application starts.
// The HideRandomWords method selects only from words that are not already hidden.

class Program
{
    static void Main(string[] args)
    {
        // Library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"),
            new Scripture(
                new Reference("Genesis", 1, 1),
                "In the beginning God created the heaven and the earth")
        };

        // Randomly select one scripture from the library
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        // Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // If every word is hidden, show the final state and end the program
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job memorizing!");
                break;
            }

            Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}