using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] message = Console.ReadLine().Split();
            Random rdmMessage = new Random();

            for (int i = 0; i < message.Length; i++)
            {
                int index = rdmMessage.Next(0, message.Length);

                string temp = message[i];
                message[i] = message[index];
                message[index] = temp;
            }


            Console.WriteLine(string.Join("\n", message));
        }
    }
}
