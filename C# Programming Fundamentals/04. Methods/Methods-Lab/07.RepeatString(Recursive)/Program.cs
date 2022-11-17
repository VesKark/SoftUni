using System;

namespace _07.RepeatString_Recursive_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());

            string newText = RepeatedText(text, repetitions);
            Console.WriteLine(newText);
        }

        static string RepeatedText(string text, int counter)
        {
            if (counter == 0)
            {
                return "";
            }
            return text + RepeatedText(text, counter - 1); //with recursion
        }
    }
}
