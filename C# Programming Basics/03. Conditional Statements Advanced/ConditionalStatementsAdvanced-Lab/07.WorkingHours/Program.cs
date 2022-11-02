using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int hourOfDay = int.Parse(Console.ReadLine()); //hour of the day in the range [0, 24]
            string dayOfWeek = Console.ReadLine(); //day of the week

            // Output  - "open" or "closed":
            
            if (dayOfWeek == "Sunday" || !(hourOfDay >= 10 && hourOfDay <= 18))
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("open");
            }
        }
    }
}
