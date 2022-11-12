using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                char input = char.Parse(Console.ReadLine());
                output += input;
            }
            Console.WriteLine(output);
        }
    }
}
