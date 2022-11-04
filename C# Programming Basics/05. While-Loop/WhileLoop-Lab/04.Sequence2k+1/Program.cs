using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int printNum = 1;

            while (printNum <= num)
            {
                Console.WriteLine(printNum);
                printNum = 2 * printNum + 1;
            }
        }
    }
}
