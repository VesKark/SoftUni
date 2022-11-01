using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;

            // Check how much bonus should be added to points:
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points <= 1000)
            {
                bonus = points * 0.2;
            }
            else if (points > 1000)
            {
                bonus = points * 0.1;
            }

            // Check if points is even number or has 5 at the end:
            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if (points % 10 == 5)
            {
                bonus += 2;
            }

            // Output:
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
