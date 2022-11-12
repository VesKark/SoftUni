using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = "";

            // Decrypting and printing message:
            for (int i = 0; i < lines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                message += (char)(input + key);
            }

            Console.WriteLine(message);
        }
    }
}
