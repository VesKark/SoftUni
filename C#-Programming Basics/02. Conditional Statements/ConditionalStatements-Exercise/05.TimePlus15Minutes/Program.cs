using System;

namespace _05.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - time:
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // Output - time:
            minutes += 15;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            
            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
