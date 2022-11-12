using System;
using System.Linq;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

                if (numbers[0] > numbers[1])
                {
                    long sumLeft = 0;
                    long leftNumber = Math.Abs(numbers[0]);
                    while (leftNumber > 0)
                    {
                        sumLeft += leftNumber % 10;
                        leftNumber /= 10;
                    }
                    Console.WriteLine(sumLeft);
                }
                else
                {
                    long sumRight = 0;
                    long rightNumber = Math.Abs(numbers[1]);
                    while (rightNumber > 0)
                    {
                        sumRight += rightNumber % 10;
                        rightNumber /= 10;
                    }
                    Console.WriteLine(sumRight);
                }
            }
        }
    }
}
