using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string favoriteBook = Console.ReadLine();
            string bookName = Console.ReadLine();

            int countBooks = 0;

            // Checking books:
            while (bookName != favoriteBook)
            {
                countBooks++;
                bookName = Console.ReadLine();

                if (bookName == "No More Books")
                {
                    break;
                }
            }

            // Output:
            if (bookName == favoriteBook)
            {
                Console.WriteLine($"You checked {countBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBooks} books.");
            }
        }
    }
}
