using System;

public class Resume
{
    // Member variables - Name and a list holding jobs
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Mehod to display resume header and job printing to each Job Object
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Call the Display method on each job object in the list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}