using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int numValue = i;
                int sumNum = 0;
                bool isSpecial = false;

                while (numValue > 0)
                {
                    sumNum += numValue % 10;
                    numValue /= 10;
                }

                if (sumNum == 5 || sumNum == 7 || sumNum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
