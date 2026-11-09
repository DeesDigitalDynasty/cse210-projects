using System;

public class Entry
{
    //Details to be added to member variables state of a journal entry
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _mood = ""; // Exceeding requirement: tracking user mood

    // Displays the individual entry details to console

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"{_entryText}");

    }
}