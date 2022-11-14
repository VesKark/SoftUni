using System;
using System.Linq;

namespace _15.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input integer array:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Find most frequent number:
            int countNum = 0;
            int countMax = 0;
            int num = 0;

            for (int i = 0; i < array.Length; i++)
            {
                foreach (int item in array)
                {
                    if (item == array[i])
                    {
                        countNum++;
                    }
                }

                if (countNum > countMax)
                {
                    countMax = countNum;
                    num = array[i];
                }

                countNum = 0;
            }

            // Output:
            Console.WriteLine(num);
        }
    }
}
