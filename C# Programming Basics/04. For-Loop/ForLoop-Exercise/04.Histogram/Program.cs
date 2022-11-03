using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            
            for (int i = 0; i < num; i++)
            {
                int inputN = int.Parse(Console.ReadLine());

                if (inputN < 200)
                {
                    countP1++;
                }
                else if (inputN < 400)
                {
                    countP2++;
                }
                else if (inputN < 600)
                {
                    countP3++;
                }
                else if (inputN < 800)
                {
                    countP4++;
                }
                else if (inputN <= 1000)
                {
                    countP5++;
                }
            }

            Console.WriteLine($"{countP1 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP2 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP3 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP4 * 100.00 / num:F2}%");
            Console.WriteLine($"{countP5 * 100.00 / num:F2}%");
        }
    }
}
