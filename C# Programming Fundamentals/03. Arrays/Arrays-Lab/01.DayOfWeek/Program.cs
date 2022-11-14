using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input a day number:
            int dayNumber = int.Parse(Console.ReadLine());

            // Print day of week:
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Invalid day!" };

            if (dayNumber > 0 && dayNumber < 8)
            {
                Console.WriteLine(dayOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine(dayOfWeek[7]);
            }
        }
    }
}
