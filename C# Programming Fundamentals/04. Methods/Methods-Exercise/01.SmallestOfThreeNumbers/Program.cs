using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestNumber();
        }

        static void SmallestNumber()
        {
            int minNum = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNum)
                {
                    minNum = number;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
