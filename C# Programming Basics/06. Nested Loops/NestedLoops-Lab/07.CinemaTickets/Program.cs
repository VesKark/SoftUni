using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input:
            string movie = Console.ReadLine();
            int freeSeats = 0;

            int countStudent = 0;
            int countStandard = 0;
            int countKid = 0;
            int countTickets = 0;

            int countAllStudent = 0;
            int countAllStandard = 0;
            int countAllKid = 0;
            int countAllTickets = 0;

            // Counting and printing movie tickets:
            while (movie != "Finish")
            {
                freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    switch (ticketType)
                    {
                        case "student": countStudent++; break;
                        case "standard": countStandard++; break;
                        case "kid": countKid++; break;                        
                    }
                    countTickets = countStudent + countStandard + countKid;

                    if (ticketType == "End" || countTickets == freeSeats)
                    {
                        Console.WriteLine($"{movie} - {countTickets * 100.00 / freeSeats:F2}% full.");
                        break;
                    }
                }

                countAllTickets += countTickets;
                countAllStudent += countStudent;
                countAllStandard += countStandard;
                countAllKid += countKid;

                countStudent = 0;
                countStandard = 0;
                countKid = 0;
                countTickets = 0;
                movie = Console.ReadLine();
            }

            if (movie == "Finish")
            {
                Console.WriteLine($"Total tickets: {countAllTickets}");
                Console.WriteLine($"{countAllStudent * 100.00 / countAllTickets:F2}% student tickets.");
                Console.WriteLine($"{countAllStandard * 100.00 / countAllTickets:F2}% standard tickets.");
                Console.WriteLine($"{countAllKid * 100.00 / countAllTickets:F2}% kids tickets.");
            }
        }
    }
}
