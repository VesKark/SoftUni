using System;

namespace _07.RepeatString
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
            string result = "";
            for (int i = 0; i < counter; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
