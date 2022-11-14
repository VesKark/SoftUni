using System;
using System.Linq;

namespace _12.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Extract middle 1, 2 or 3 elements:
            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{ " + array[array.Length / 2 - 1] + ", " + array[array.Length / 2] + " }");
            }
            else
            {
                Console.WriteLine("{ " + array[array.Length / 2 - 1] + ", " + array[array.Length / 2] + ", " + array[array.Length / 2 + 1] + " }");
            }
        }
    }
}
