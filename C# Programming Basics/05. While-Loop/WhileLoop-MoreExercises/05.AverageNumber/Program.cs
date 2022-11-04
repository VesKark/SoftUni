using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int inputN = 0;
            int sum = 0;
            int count = 0;

            for (int i = 0; i < number; i++)
            {
                inputN = int.Parse(Console.ReadLine());
                sum += inputN;
                count++;
            }

            Console.WriteLine($"{sum * 1.00 / count:F2}");
        }
    }
}
