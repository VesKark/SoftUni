using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            // Estimating sum of element digits:
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int length = numbers[i].ToString().Length;

                for (int j = 0; j < length; j++)
                {
                    sum += numbers[i] % 10;
                    numbers[i] /= 10;
                }
                numbers[i] = sum;
            }

            // Searching corresponding index in text:
            string output = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = numbers[i];

                if (counter >= text.Length)
                {
                    counter -= text.Length;
                }
                output += text[counter];
                text = text.Remove(counter, 1);
            }

            Console.WriteLine(output);
        }
    }
}
