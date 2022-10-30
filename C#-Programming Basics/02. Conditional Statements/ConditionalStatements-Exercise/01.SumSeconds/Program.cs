using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - time to finish in seconds:
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            // Estimating total time:
            int totalTime = firstTime + secondTime + thirdTime; //in seconds

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            // Output:
            Console.WriteLine($"{minutes}:{seconds:D2}");        
        }
    }
}
