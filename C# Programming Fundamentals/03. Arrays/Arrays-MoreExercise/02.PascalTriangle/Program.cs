using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input Pascal Triangle rows:
            int rows = int.Parse(Console.ReadLine());

            // Printing triangle:
            if (rows >= 1)
            {
                Console.WriteLine(1);
            }

            int[] newArray = new int[2];
            int[] secondaryArray = new int[3];

            for (int i = 2; i <= rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < newArray.Length; j++)
                    {
                        if (j == 0 || j == newArray.Length - 1)
                        {
                            newArray[j] = 1;
                        }
                        else
                        {
                            newArray[j] = secondaryArray[j - 1] + secondaryArray[j];
                        }
                    }
                    secondaryArray = new int[i + 1];
                    Console.WriteLine(String.Join(" ", newArray));
                }
                else if (i % 2 != 0)
                {
                    for (int j = 0; j < secondaryArray.Length; j++)
                    {
                        if (j == 0 || j == secondaryArray.Length - 1)
                        {
                            secondaryArray[j] = 1;
                        }
                        else
                        {
                            secondaryArray[j] = newArray[j - 1] + newArray[j];
                        }
                    }
                    newArray = new int[i + 1];
                    Console.WriteLine(String.Join(" ", secondaryArray));
                }
            }
        }
    }
}
