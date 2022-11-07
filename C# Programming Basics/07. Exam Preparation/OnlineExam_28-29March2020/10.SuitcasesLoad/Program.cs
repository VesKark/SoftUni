using System;

namespace _10.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double capacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // Estimating if the luggage capacity is enough:
            double suitcaseKG = 0;
            int count = 0;

            while (input != "End")
            {
                suitcaseKG = double.Parse(input);
                count++;

                if (count % 3 == 0)
                {
                    suitcaseKG *= 1.10; //volume increase with 10%
                }
                capacity -= suitcaseKG;

                if (capacity < 0)
                {
                    count--;
                    break;
                }

                input = Console.ReadLine();
            }

            // Output:
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {count} suitcases loaded.");            
        }
    }
}
