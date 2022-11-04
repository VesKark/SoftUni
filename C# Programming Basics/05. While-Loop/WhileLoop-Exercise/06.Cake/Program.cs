using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input cake sizes:
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cakePieces = width * length;

            string takenPieces = Console.ReadLine();
            int pieces = 0;

            // Eating the cake:
            while (takenPieces != "STOP")
            {
                pieces = int.Parse(takenPieces);
                cakePieces -= pieces;

                if (cakePieces <= 0)
                {
                    break;
                }
                takenPieces = Console.ReadLine();
            }

            // Output:
            if (cakePieces > 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
