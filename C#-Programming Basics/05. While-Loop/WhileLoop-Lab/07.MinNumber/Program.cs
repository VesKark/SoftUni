using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;

            while (input != "Stop")
            {
                int inputNum = int.Parse(input);

                if (inputNum < minNum)
                {
                    minNum = inputNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
