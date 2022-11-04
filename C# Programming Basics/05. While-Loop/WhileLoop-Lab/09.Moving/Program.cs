using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string packing = Console.ReadLine();

            // Checking storage space while moving to apartment:
            int freeSpaceLeft = width * length * height;

            while (packing != "Done")
            {
                int box = int.Parse(packing);
                freeSpaceLeft -= box;

                if (freeSpaceLeft <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpaceLeft)} Cubic meters more.");
                    break;
                }

                packing = Console.ReadLine();
            }

            if (packing == "Done")
            {
                Console.WriteLine($"{freeSpaceLeft} Cubic meters left.");
            }
        }
    }
}
