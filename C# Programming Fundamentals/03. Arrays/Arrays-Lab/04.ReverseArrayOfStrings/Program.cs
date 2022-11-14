using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read and reverse array of strings:
            string[] inputArray = Console.ReadLine().Split().Reverse().ToArray();

            // Print reversed array:
            foreach (string item in inputArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
