using System;
using System.Collections.Generic;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and Output:
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(getFibonacci(n, new Dictionary<int, long>()));
        }
           
        private static long getFibonacci(int n, Dictionary<int, long> dict)
        {
            // Declaring Funcion:
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                if (dict.ContainsKey(n))
                {
                    return dict[n];
                }
                else
                {
                    dict.Add(n, getFibonacci(n - 1, dict) + getFibonacci(n - 2, dict));
                    return (getFibonacci(n - 1, dict) + getFibonacci(n - 2, dict));
                }
            }
        }
    }
}
