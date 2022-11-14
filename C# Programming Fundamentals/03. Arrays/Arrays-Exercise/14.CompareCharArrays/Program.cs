using System;
using System.Linq;

namespace _14.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input arrays:
            char[] arrayOne = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayTwo = Console.ReadLine().Split().Select(char.Parse).ToArray();

            // Printing arrays in alphabetical order:
            int arrayLength = Math.Min(arrayOne.Length, arrayTwo.Length);
            bool isEqual = true;

            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                    isEqual = false;
                    break;
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                    isEqual = false;
                    break;
                }                
            }

            if (isEqual)
            {
                if (arrayOne.Length <= arrayTwo.Length)
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                }
            }
        }
    }
}
