using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            char lastSector = char.Parse(Console.ReadLine()); //last sector [B to Z], first sector is always A
            int rowsA = int.Parse(Console.ReadLine()); //rows in sector A
            int seatsOddRows = int.Parse(Console.ReadLine()); //number of seats on the odd rows

            // Generating seats:
            int additionalSeats = 0;
            int countSeats = 0;

            for (int sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= rowsA; row++)
                {
                    if (row % 2 == 0)
                    {
                        additionalSeats = 2;
                    }
                    else
                    {
                        additionalSeats = 0;
                    }

                    for (int seats = 'a'; seats < 'a' + seatsOddRows + additionalSeats; seats++)
                    {
                        Console.WriteLine($"{(char)sector}{row}{(char)seats}");
                        countSeats++;
                    }                    
                }
                rowsA++;
            }
            Console.WriteLine(countSeats);
        }
    }
}
