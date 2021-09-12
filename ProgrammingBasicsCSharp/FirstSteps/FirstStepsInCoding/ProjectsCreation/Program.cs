using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hoursToComplete = 3;
            int hours = projects * hoursToComplete;

            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {projects} project/s.");
        }

    }
}
