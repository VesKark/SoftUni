using System;
using System.Linq;

namespace _16.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input lowercase word:
            string letters = Console.ReadLine();

            // Print index of letters:
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]} -> {letters[i] - 97}");
            }
        }
    }
}
