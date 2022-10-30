using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            // Checking password:
            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
