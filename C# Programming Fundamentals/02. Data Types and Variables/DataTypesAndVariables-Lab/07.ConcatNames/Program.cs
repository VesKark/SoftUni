using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            string inputC = Console.ReadLine();

            Console.Write($"{inputA}{inputC}{inputB}");
        }
    }
}
