using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            List<int> digits = new List<int>();

            // Take and store digits in a list:
            int count = 0;
            while (count != inputText.Length)
            {
                char item = inputText[count];
                if (char.IsDigit(item))
                {
                    digits.Add(item - 48);
                    inputText = inputText.Remove(count, 1);
                    count--;
                }
                count++;
            }

            // Split list into Take & Skip lists:
            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();
            List<string> result = new List<string>();

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else if (i % 2 != 0)
                {
                    skipList.Add(digits[i]);
                }
            }

            for (int i = 0; i < digits.Count / 2; i++)
            {
                // take value:
                int takeLength = takeList[i];
                if (takeLength >= inputText.Length)
                {
                    takeLength = inputText.Length;
                }
                string subText = inputText.Substring(0, takeLength);
                result.Add(subText);
                inputText = inputText.Remove(0, takeLength);
                

                // skip value:
                int skipLength = skipList[i];
                if (skipLength >= inputText.Length)
                {
                    skipLength = inputText.Length;
                }
                inputText = inputText.Remove(0, skipLength);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
