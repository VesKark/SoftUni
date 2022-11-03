using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double inheritance = double.Parse(Console.ReadLine()); //inherited money
            int lastYear = int.Parse(Console.ReadLine()); //last year [1800 - last year]

            int countAge = 18;

            for (int i = 1800; i <= lastYear; i++)
            {
                if (i % 2 == 0)
                {
                    inheritance -= 12000.00;
                }
                else
                {
                    inheritance -= 12000.00 + 50 * countAge;
                }
                countAge++;
            }

            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):F2} dollars to survive.");
            }

        }
    }
}
