using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;

            while (input != "Stop")
            {
                int inputNum = int.Parse(input);

                if (inputNum > maxNum)
                {
                    maxNum = inputNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNum);
        }
    }
}
