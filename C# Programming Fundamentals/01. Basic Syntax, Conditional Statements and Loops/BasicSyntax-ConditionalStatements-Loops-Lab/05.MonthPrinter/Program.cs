﻿using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input month number:
            int monthNr = int.Parse(Console.ReadLine());
            string monthName = string.Empty;

            // Output month name:
            switch (monthNr)
            {
                case 1: monthName = "January"; break;
                case 2: monthName = "February"; break;
                case 3: monthName = "March"; break;
                case 4: monthName = "April"; break;
                case 5: monthName = "May"; break;
                case 6: monthName = "June"; break;
                case 7: monthName = "July"; break;
                case 8: monthName = "August"; break;
                case 9: monthName = "September"; break;
                case 10: monthName = "October"; break;
                case 11: monthName = "November"; break;
                case 12: monthName = "December"; break;
                default: monthName = "Error!"; break;
            }

            Console.WriteLine(monthName);
        }
    }
}
