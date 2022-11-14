using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input two arrays:
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            // Compare array elements:
            foreach (var item in arrayTwo)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (item == arrayOne[i])
                    {
                        Console.Write(item + " ");
                    }
                }
            }

            // Second solution:
            //string[] output = arrayTwo.Intersect(arrayOne).ToArray();

            //foreach (var item in output)
            //{
            //    Console.Write(item + " ");
            //}
        }
    }
}
