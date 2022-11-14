using System;
using System.Linq;

namespace _12.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
                        
            // Rotating array and estimating sum:
            int arrayLength = inputArray.Length;
            int[] resultArray = new int[arrayLength];
            int temp = 0;

            for (int i = 0; i < rotations; i++)
            {
                temp = inputArray[arrayLength - 1];

                for (int j = arrayLength - 1; j > 0; j--)
                {
                    resultArray[j] += inputArray[j - 1];
                    inputArray[j] = inputArray[j - 1];
                }

                resultArray[0] += temp;
                inputArray[0] = temp;
            }

            // Printing result:
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
