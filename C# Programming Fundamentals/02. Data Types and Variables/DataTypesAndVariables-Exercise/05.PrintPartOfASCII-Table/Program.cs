using System;

namespace _05.PrintPartOfASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int charStart = int.Parse(Console.ReadLine());
            int charEnd = int.Parse(Console.ReadLine());

            // Print chars on the console:
            for (int i = charStart; i <= charEnd; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
