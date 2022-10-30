using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int hoursNeeded = int.Parse(Console.ReadLine()); //hours needed to finish the project [h]
            int days = int.Parse(Console.ReadLine()); //available days in the firm [d]
            int workers = int.Parse(Console.ReadLine()); //workers, working overtime

            // Available hours to finish the project, when:
                // 1) the workers are in the firm -> 90% of the days
                // 2) normal working time 8 hours/day
                // 3) overtime 2 hours/day
            double hours = Math.Floor((0.9 * days * 8) + (workers * days * 2));

            // Output:
            if (hoursNeeded <= hours)
            {
                Console.WriteLine($"Yes!{hours - hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - hours} hours needed.");
            }
        }
    }
}
