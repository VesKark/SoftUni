using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int fieldCells = int.Parse(Console.ReadLine());
            int[] ladybugStart = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Building start array:
            int[] fieldStart = new int[fieldCells];

            for (int i = 0; i < fieldCells; i++)
            {
                for (int j = 0; j < ladybugStart.Length; j++)
                {
                    if (i == ladybugStart[j])
                    {
                        fieldStart[i] = 1;
                        break;
                    }
                    else
                    {
                        fieldStart[i] = 0;
                    }
                }
            }

            // Arranging flying ladybugs:
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] ladybugMove = input.Split();
                int currentIndex = int.Parse(ladybugMove[0]);
                int currentMove = int.Parse(ladybugMove[2]);
                int firstIndex = currentIndex;

                if (currentMove == 0 || (currentIndex < 0 || currentIndex >= fieldCells))
                {
                    input = Console.ReadLine();
                    continue;
                }

                while (fieldStart[currentIndex] != 0)
                {
                    if (ladybugMove[1] == "right")
                    {
                        currentIndex += currentMove;
                    }
                    else if (ladybugMove[1] == "left")
                    {
                        currentIndex -= currentMove;
                    }

                    bool inRange = currentIndex >= 0 && currentIndex < fieldCells;
                    if (!inRange)
                    {
                        break;
                    }
                }

                if (currentIndex >= 0 && currentIndex < fieldCells && firstIndex != currentIndex)
                {
                    fieldStart[currentIndex] = 1;
                    fieldStart[firstIndex] = 0;
                }
                else if (firstIndex != currentIndex)
                {
                    fieldStart[firstIndex] = 0;
                }

                input = Console.ReadLine();
            }

            // Output:
            Console.WriteLine(String.Join(" ", fieldStart));
        }
    }
}