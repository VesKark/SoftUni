using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // Estimating time after 30 minutes:
            minutes += 30;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }

            // Output:
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
