using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string inputReversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                inputReversed += input[i];
            }

            Console.WriteLine(inputReversed);
        }
    }
}
