using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timeForAllProjects = numberOfProjects * 3;

            Console.WriteLine($"The architect {architectName} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
