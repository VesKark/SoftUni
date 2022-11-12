using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int originValue = 0;
            bool isSpecial = false;

            for (int i = 1; i <= num; i++)
            {
                originValue = i;
                while (originValue > 0)
                {
                    sum += originValue % 10;
                    originValue /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
                sum = 0;
            }
        }
    }
}
