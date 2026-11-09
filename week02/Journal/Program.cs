using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        // Main program loop presenting the menu until the user chooses to quit
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    // Get a random prompt and display it to the user
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string userEntry = Console.ReadLine();

                    // Exceeding requirements: Prompt for user mood
                    Console.Write("How are you feeling today? (e.g., Happy, Reflective, Grateful): ");
                    string userMood = Console.ReadLine();

                    // Capture current date
                    string currentDate = DateTime.Now.ToShortDateString();

                    // Create4 a new Entry object
                    Entry newEntry = new Entry();
                    newEntry._date = currentDate;
                    newEntry._promptText = prompt;
                    newEntry._entryText = userEntry;
                    newEntry._mood = userMood;

                    // Add the entry to journal
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine();
                }
                else if (choice == 2)
                {
                    // Display all entries stored in the journal
                    theJournal.DisplayAll();
                }
                else if (choice == 3)
                {
                    // Ask user for filename and save entries
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                }
                else if (choice == 4)
                {
                    // Ask user for filename
                    Console.Write("Enter filename to load (e.g., journal.txt): ");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select between 1 and 5.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
            }
        }
    }
}