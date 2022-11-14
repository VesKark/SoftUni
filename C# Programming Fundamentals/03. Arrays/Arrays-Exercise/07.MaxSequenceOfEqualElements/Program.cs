using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Find the longest to the left sequence:
            int counter = 1;
            int counterMax = 1;
            int value = 0;
            int valueMax = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    value = array[i];
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        valueMax = value;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            // Print result:
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(valueMax + " ");
            }
        }
    }
}
