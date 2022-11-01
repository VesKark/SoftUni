using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesOfBook = int.Parse(Console.ReadLine());
            double readPagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double timeToReadTheBook = pagesOfBook / readPagesPerHour;
            double readingHoursPerDay =  timeToReadTheBook / days;

            Console.WriteLine(readingHoursPerDay);
        }
    }
}
