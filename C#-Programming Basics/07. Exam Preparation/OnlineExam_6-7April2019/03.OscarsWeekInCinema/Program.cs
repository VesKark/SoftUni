using System;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string movieName = Console.ReadLine(); //"A Star Is Born", "Bohemian Rhapsody","Green Book" or "The Favourite"
            string hallType = Console.ReadLine(); //"normal", "luxury" or "ultra luxury"
            int boughtTickets = int.Parse(Console.ReadLine());

            // Estimating movie theater win:
            double ticketPrice = 0;

            if (hallType == "normal")
            {
                switch (movieName)
                {
                    case "A Star Is Born": ticketPrice = 7.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 7.35; break;
                    case "Green Book": ticketPrice = 8.15; break;
                    case "The Favourite": ticketPrice = 8.75; break;
                }
            }
            else if (hallType == "luxury")
            {
                switch (movieName)
                {
                    case "A Star Is Born": ticketPrice = 10.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 9.45; break;
                    case "Green Book": ticketPrice = 10.25; break;
                    case "The Favourite": ticketPrice = 11.55; break;
                }
            }
            else if (hallType == "ultra luxury")
            {
                switch (movieName)
                {
                    case "A Star Is Born": ticketPrice = 13.50; break;
                    case "Bohemian Rhapsody": ticketPrice = 12.75; break;
                    case "Green Book": ticketPrice = 13.25; break;
                    case "The Favourite": ticketPrice = 13.95; break;
                }
            }

            // Output:
            double theaterWin = ticketPrice * boughtTickets;
            Console.WriteLine($"{movieName} -> {theaterWin:F2} lv.");
        }
    }
}
