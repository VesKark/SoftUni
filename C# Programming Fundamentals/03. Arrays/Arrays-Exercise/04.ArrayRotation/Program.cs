using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array:
            string[] inputArray = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            rotations %= inputArray.Length;

            // Rotating array:
            string temp = "";

            for (int i = 0; i < rotations; i++)
            {
                temp = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[inputArray.Length - 1] = temp;
            }

            // Printing rotated array:
            foreach (var item in inputArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
