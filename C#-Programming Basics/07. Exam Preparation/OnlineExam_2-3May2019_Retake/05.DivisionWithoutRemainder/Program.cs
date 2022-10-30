using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num = int.Parse(Console.ReadLine());

            // Estimating percentages:
            double percentageRest2 = 0;
            double percentageRest3 = 0;
            double percentageRest4 = 0;
            int countRest2 = 0;
            int countRest3 = 0;
            int countRest4 = 0;
            int input = 0;

            for (int i = 0; i < num; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    countRest2++;
                }
                if (input % 3 == 0)
                {
                    countRest3++;
                }
                if (input % 4 == 0)
                {
                    countRest4++;
                }
            }

            percentageRest2 = countRest2 * 100.00 / num;
            percentageRest3 = countRest3 * 100.00 / num;
            percentageRest4 = countRest4 * 100.00 / num;

            // Output:
            Console.WriteLine($"{percentageRest2:F2}%");
            Console.WriteLine($"{percentageRest3:F2}%");
            Console.WriteLine($"{percentageRest4:F2}%");
        }
    }
}
