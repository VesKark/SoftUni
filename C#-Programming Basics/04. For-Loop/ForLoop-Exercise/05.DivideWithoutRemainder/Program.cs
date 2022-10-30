using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double countP1 = 0; //percentage of num % 2 == 0
            double countP2 = 0; //percentage of num % 3 == 0
            double countP3 = 0; //percentage of num % 4 == 0

            for (int i = 0; i < num; i++)
            {
                int inputN = int.Parse(Console.ReadLine());
                if (inputN % 2 == 0)
                {
                    countP1++;
                }
                if (inputN % 3 == 0)
                {
                    countP2++;
                }
                if (inputN % 4 == 0)
                {
                    countP3++;
                }
            }

            Console.WriteLine($"{countP1 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP2 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP3 * 100.00 / num:F2}%");
        }
    }
}
