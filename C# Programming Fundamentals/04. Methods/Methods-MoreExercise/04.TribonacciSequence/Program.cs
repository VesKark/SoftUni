using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int[] tribonacciSeq = new int[counter];
            BuildTribonacci(tribonacciSeq);
            
            Console.WriteLine(String.Join(" ", tribonacciSeq));
        }

        static void BuildTribonacci(int[] tribonacci)
        {
            tribonacci[0] = 1;
            for (int i = 1; i < tribonacci.Length; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    tribonacci[i] += tribonacci[i - j];
                    if (i == j)
                    {
                        break;
                    }
                }
            }
        }
    }
}
