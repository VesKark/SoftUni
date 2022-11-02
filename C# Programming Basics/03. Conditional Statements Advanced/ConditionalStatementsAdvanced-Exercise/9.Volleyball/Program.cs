using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string year = Console.ReadLine(); //"leap" or "normal"
            int holidays = int.Parse(Console.ReadLine()); //number of holidays in the year (no weekends)
            int weekendsHometown = int.Parse(Console.ReadLine()); //number of weekends at hometown

            // Output:
            double weekendsSofia = (48 - weekendsHometown) * 3.00 / 4;
            double holidaysSofia = holidays * 2.00 / 3;
            double daysOfPlay = weekendsSofia + weekendsHometown + holidaysSofia;

            if (year == "leap")
            {
                daysOfPlay *= 1.15;
            }

            Console.WriteLine(Math.Floor(daysOfPlay));
        }
    }
}
