using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int floors = int.Parse(Console.ReadLine()); //number of floors
            int rooms = int.Parse(Console.ReadLine()); //number of rooms on each floor

            // Printing room numbers:
            for (int countFloors = floors; countFloors >= 1; countFloors--)
            {                
                for (int countRooms = 0; countRooms < rooms; countRooms++)
                {
                    if (floors == 1 || countFloors == floors)
                    {
                        Console.Write($"L{countFloors}{countRooms} ");                        
                    }
                    else if (countFloors % 2 != 0)
                    {
                        Console.Write($"A{countFloors}{countRooms} ");
                    }
                    else
                    {
                        Console.Write($"O{countFloors}{countRooms} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
